/******************************************************************************/
/* Copyright 2017, MB Capital Services GmbH.  All rights reserved.            */
/* This sample source code is provided for demonstration purposes only.       */
/******************************************************************************/

/******************************************************************************/
/* Name:     Country_Eval                                                     */
/* Title:    Laenderauswertung                                                */
/* Author:   CSG_YL                                                           */
/* Created:  May 02, 2017                                                     */
/*                                                                            */
/* Version:  1.0                                                              */
/* Platform: .NET 2.0 | Mono                                                  */
/*                                                                            */
/* Description:                                                               */
/*      Tool zur Laenderauswertung                                            */
/*                                                                            */
/* History:                                                                   */
/*      11/06/2015 - Initial version v0.1                                     */
/*      11/18/2015 - Bugfix release v0.2:                                     */
/*                   Improved: Rows in output are sorted by country code      */
/*                   Improved: Sum (Onsite/Online/Total) is calculated        */
/*                             automatically                                  */
/*                   Improved: Added "Antarktis" [AQ]                         */
/*                   Fixed:    Wrong country column for some exports (leads   */
/*                             to many unknown countries)                     */
/*                   Fixed:    Unrecognized countries due to different names  */
/*                             United Kingdom -> Vereinigtes Königreich [GB]  */
/*                             Slovenien      -> Slowenien              [SI]  */
/*                             Moldavien      -> Republik Moldau        [MD]  */
/*                             etc.                                           */
/*                   Misc:     Minor general improvements                     */
/*      12/02/2015 - Update release v0.3:                                     */
/*                   Improved: Added SecuTix One export processing            */
/*                   Improved: Added selection for ticket type                */
/*                   Updated:  New mapping for country codes and names        */
/*      01/27/2016 - Update release v0.4:                                     */
/*                   Improved: Added "Kosovo" [XK]                            */
/*      02/03/2016 - Hotfix release v0.5:                                     */
/*                   Improved: Hotfixes for wrong country codes               */
/*                   Improved: Correction of some special chars parsed wrong  */
/*      02/15/2016 - Update release v0.6:                                     */
/*                   Improved: Faster algorithm for non-distinct search       */
/*                   Improved: Added IE9 compatibility option                 */
/*                   Improved: Sorted 'TabIndex' of WinForms                  */
/*      04/11/2016 - Bugfix release v0.7:                                     */
/*                   Fixed:    Checkflow 'out' counts as 'in'                 */
/*                   Updated:  Added SAP mapping for country codes and names  */
/*      09/26/2016 - Update release v0.8:                                     */
/*                   Updated:  Added support for new country column           */
/*                   Improved: Added "Aland" [AX]                             */
/*                   Misc:     Minor general improvements                     */
/*      02/03/2017 - Update release v0.9:                                     */
/*                   Updated:  Added support for new questionnaire export     */
/*                   Misc:     Minor general improvements                     */
/*      05/02/2017 - Update release v1.0:                                     */
/*                   Misc:     Minor refactoring                              */
/******************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Advantage.Data.Provider;  // v7.0 is x86 only!

namespace Country_Eval
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> seasonNamesSecutix360 = new Dictionary<string, string>();    // dict for "season name" -> "filename of season"
        private Dictionary<string, string> seasonNamesSecutixOne = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            txtSecutix360Dir.Text = Properties.Settings.Default["Secutix360Dir"].ToString();
            txtSecutixOneDir.Text = Properties.Settings.Default["SecutixOneDir"].ToString();
            txtEKSDir.Text = Properties.Settings.Default["EKSDir"].ToString();
            if (string.IsNullOrEmpty(Properties.Settings.Default["HotMaxPath"].ToString()))
            {
                txtHotmaxPath.Text = "\\\\127.0.0.1\\ticketplatte$\\TicketHotMax\\Daten";
            }
            else
            {
                txtHotmaxPath.Text = Properties.Settings.Default["HotMaxPath"].ToString();
            }
            refreshSeasons();
            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            // lblStatus.Text = "© " + DateTime.Now.Year.ToString() + " CSG Team GmbH.";
            lblStatus.Text = "© 2007 CSG Team GmbH.";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K && e.Control)
            {
                if (txtCSVOut.ReadOnly)
                {
                    txtSecutix360Dir.ReadOnly = false;
                    txtSecutixOneDir.ReadOnly = false;
                    txtEKSDir.ReadOnly = false;
                    txtCSVOut.ReadOnly = false;
                }
                else
                {
                    txtSecutix360Dir.ReadOnly = true;
                    txtSecutixOneDir.ReadOnly = true;
                    txtEKSDir.ReadOnly = true;
                    txtCSVOut.ReadOnly = true;
                    refreshSeasons();
                }
                if (!validDir())
                {
                    MessageBox.Show("Directories for SecuTix 360, One, and EKS have to be different.", "Invalid directory");
                }
                else
                {
                    Properties.Settings.Default["Secutix360Dir"] = txtSecutix360Dir.Text;
                    Properties.Settings.Default["SecutixOneDir"] = txtSecutixOneDir.Text;
                    Properties.Settings.Default["EKSDir"] = txtEKSDir.Text;
                    Properties.Settings.Default["HotMaxPath"] = txtHotmaxPath.Text;
                    Properties.Settings.Default.Save();
                    preflight();
                }
            }
            else if (e.KeyCode == Keys.L && e.Control)
            {
                MessageBox.Show("The season lists have been refreshed.", "Seasons refreshed");
                if (!validDir())
                {
                    MessageBox.Show("Directories for SecuTix 360, One, and EKS have to be different.", "Invalid directory");
                }
                else
                {
                    refreshSeasons();
                    Properties.Settings.Default["Secutix360Dir"] = txtSecutix360Dir.Text;
                    Properties.Settings.Default["SecutixOneDir"] = txtSecutixOneDir.Text;
                    Properties.Settings.Default["EKSDir"] = txtEKSDir.Text;
                    Properties.Settings.Default["HotMaxPath"] = txtHotmaxPath.Text;
                    Properties.Settings.Default.Save();
                    preflight();
                }
            }
        }

        private void refreshSeasons()
        {
            seasonNamesSecutix360.Clear();
            seasonNamesSecutixOne.Clear();
            lstSeasons.Items.Clear();
            try
            {
                if (txtSecutix360Dir.TextLength > 0)
                {
                    string[] exportFilesSecutix360 = Directory.GetFiles(txtSecutix360Dir.Text, "*.csv");
                    foreach (string fileName in exportFilesSecutix360)
                    {
                        try
                        {   // Open each CSV file using a stream reader
                            using (StreamReader sr = new StreamReader(fileName))
                            {
                                string[] stHead = sr.ReadLine().Replace("\"", "").Split('\t', ';');     // first line with headings
                                string seasonName;
                                if (Array.IndexOf(stHead, "SEASON") > 0)
                                {
                                    sr.ReadLine();  // skip one (empty) line
                                    seasonName = sr.ReadLine().Replace("\"", "").Split('\t')[Array.IndexOf(stHead, "SEASON")];
                                }
                                else
                                {
                                    seasonName = sr.ReadLine().Replace("\"", "").Split(';')[2];     // column 2 (zero-based) is name of season
                                }
                                try
                                {
                                    seasonNamesSecutix360.Add(seasonName, fileName);
                                    lstSeasons.Items.Add(seasonName);
                                }
                                catch (ArgumentException)
                                {
                                    MessageBox.Show("An element with key = \"" + seasonName + "\" already exists.", "Error");
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The file could not be read:");
                            Console.WriteLine(e.Message);
                            MessageBox.Show(e.Message, "The file could not be read");
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not available: " + txtSecutix360Dir.Text);
                MessageBox.Show("Directory not available: " + txtSecutix360Dir.Text, "Error");
            }
        }

        /* Select directory with SecuTix 360 exports */
        private void btnSecutix360Dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSecutix360Dir.Text = fbd.SelectedPath;
                refreshSeasons();
                Properties.Settings.Default["Secutix360Dir"] = fbd.SelectedPath;
                Properties.Settings.Default.Save();
                if (!validDir())
                {
                    MessageBox.Show("Directories for SecuTix 360, One, and EKS have to be different.", "Invalid directory");
                }
                else
                {
                    preflight();
                }
            }
        }

        /* Select directory with SecuTix One exports */
        private void btnSecutixOneDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSecutixOneDir.Text = fbd.SelectedPath;
                Properties.Settings.Default["SecutixOneDir"] = fbd.SelectedPath;
                Properties.Settings.Default.Save();
                if (!validDir())
                {
                    MessageBox.Show("Directories for SecuTix 360, One, and EKS have to be different.", "Invalid directory");
                }
                else
                {
                    preflight();
                }
            }
        }

        /* Select directory with EKS exports */
        private void btnEKSDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEKSDir.Text = fbd.SelectedPath;
                Properties.Settings.Default["EKSDir"] = fbd.SelectedPath;
                Properties.Settings.Default.Save();
                if (!validDir())
                {
                    MessageBox.Show("Directories for SecuTix 360, One, and EKS have to be different.", "Invalid directory");
                }
                else
                {
                    preflight();
                }
            }
        }

        /* Select CSV file for output */
        private void btnCSVOut_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveCSVDialog = new SaveFileDialog();
            saveCSVDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveCSVDialog.FilterIndex = 1;
            saveCSVDialog.Title = "Select a file";
            saveCSVDialog.RestoreDirectory = true;
            if (saveCSVDialog.ShowDialog() == DialogResult.OK)
            {
                txtCSVOut.Text = saveCSVDialog.FileName;
            }
            preflight();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

            Properties.Settings.Default["HotMaxPath"] = txtHotmaxPath;
            Properties.Settings.Default.Save();

            /* Define the lists here (not parent scope) to clear them on each btn click */
            List<string> shBarcode = new List<string>();
            List<string> shCountry = new List<string>();
            List<string> shType = new List<string>();
            List<string> eksBarcode = new List<string>();
            List<string> mergedBarcode = new List<string>();
            List<string> mergedCountry = new List<string>();
            List<string> mergedType = new List<string>();

            seasonNamesSecutixOne.Clear();
            string[] exportFilesSecutixOne = Directory.GetFiles(txtSecutixOneDir.Text, "*.csv");
            foreach (string fileName in exportFilesSecutixOne)
            {
                try
                {   // Open each CSV file using a stream reader
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        sr.ReadLine();  // 1st line could have headings, just skip it
                        string seasonName = sr.ReadLine().Split('\t')[7];  // column 7 (zero-based) is name of season
                        try
                        {
                            seasonNamesSecutixOne.Add(seasonName, fileName);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("An element with Key = \"" + seasonName + "\" already exists.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "The file could not be read");
                }
            }

            /* Read SecuTix 360 data */
            try
            {   // Open the CSV file using a stream reader
                using (StreamReader srs = new StreamReader(seasonNamesSecutix360[lstSeasons.SelectedItem.ToString()], Encoding.Default))   // we're using the dictionary here
                {
                    string stLine = srs.ReadLine().Replace("\"", "");   // first line with headings
                    string[] stHead = stLine.Split('\t', ';');
                    string[] stValues;
                    while (!srs.EndOfStream)
                    {
                        stLine = srs.ReadLine().Replace("\"", "")   // from 2nd line on
                            .Replace("auml;", "ä").Replace("Auml;", "Ä")    // without "&" for doubles ("&amp;auml;")
                            .Replace("ouml;", "ö").Replace("Ouml;", "Ö")
                            .Replace("uuml;", "ü").Replace("Uuml;", "Ü")
                            .Replace("szlig;", "ß").Replace("&amp;", "&")
                            .Replace("rsquo;", "’").Replace("#8217;", "’")
                            .Replace("&apos;", "'").Replace("#39;", "'");
                        stValues = stLine.Split('\t', ';');
                        if (stValues[1].Length > 0)     // if no barcode, skip this line
                        {
                            shBarcode.Add(stValues[1].Substring(0, 16));
                            if (Array.IndexOf(stHead, "Q20") > 0)
                            {
                                if (stValues[Array.IndexOf(stHead, "Q20")].Length > 1)
                                {
                                    shCountry.Add(stValues[Array.IndexOf(stHead, "Q20")]);
                                }
                                else
                                {
                                    shCountry.Add(stValues[Array.IndexOf(stHead, "COUNTRY")]);
                                }
                            }
                            else if (Array.IndexOf(stHead, "Land (messe)") > 0)
                            {
                                shCountry.Add(stValues[Array.IndexOf(stHead, "Land (messe)")]);
                            }
                            else if (Array.IndexOf(stHead, "Land (neu)") > 0)
                            {
                                shCountry.Add(stValues[Array.IndexOf(stHead, "Land (neu)")]);
                            }
                            else
                            {
                                shCountry.Add(stValues[Array.IndexOf(stHead, "Land")]);
                            }
                            shType.Add("Online");
                        }
                    }
                    Console.WriteLine("SecuTix 360 records imported: " + shBarcode.Count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The SecuTix file could not be read:");
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "The SecuTix 360 file could not be read");
            }

            /* Read SecuTix One data */
            try
            {   // Open the CSV file using a stream reader
                using (StreamReader srs = new StreamReader(seasonNamesSecutixOne[lstSeasons.SelectedItem.ToString()], Encoding.Default))   // we're using the dictionary here
                {
                    string stLine = srs.ReadLine();   // first line with headings
                    string[] stHead = stLine.Split('\t');
                    string[] stValues;
                    while (!srs.EndOfStream)
                    {
                        stLine = srs.ReadLine().Replace("\"", "");  // from 2nd line on
                        stValues = stLine.Split('\t');
                        shBarcode.Add(stValues[11].Substring(0, 16));
                        if (Array.IndexOf(stHead, "COUNTRY") > 0)
                        {
                            shCountry.Add(stValues[Array.IndexOf(stHead, "COUNTRY")]);
                        }
                        else
                        {
                            shCountry.Add("n/a");
                        }
                        shType.Add("Online");
                    }
                    Console.WriteLine("Total SecuTix records imported: " + shBarcode.Count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The SecuTix file could not be read:");
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "The SecuTix One file could not be read");
            }

            /* Read HotMax data */
            /* Don't forget to change "Platform target" in Project Properties to "x86". */
            // create a connection object
            AdsConnection conn = new AdsConnection("data source=" + txtHotmaxPath.Text + "; ServerType=remote|local; TableType=ADT");
            AdsCommand cmd;
            AdsDataReader reader;
            try
            {   // connect to server
                lblStatus.Text = "Connecting to HotMax server...";
                Application.DoEvents();     // refreshing GUI
                conn.Open();
                Console.WriteLine("Connection String: " + conn.ConnectionString.ToString());
                Console.WriteLine("Current Connection State: " + conn.State.ToString());
                // create a command object
                cmd = conn.CreateCommand();
                // increase timeout from 30 (default) to 60 seconds.
                cmd.CommandTimeout = 60;
                // specify a SELECT statement
                cmd.CommandText = "select * from lktokasse,mesreg where mesreg.MesseCode like '"
                    + lstSeasons.SelectedItem.ToString()
                    + "' and lktokasse.vonkontotrans=mesreg.kunde";
                Console.WriteLine(cmd.CommandText);
                // execute the statement and create a reader
                lblStatus.Text = "Importing HotMax data...";
                Application.DoEvents();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    shBarcode.Add(reader.GetValue(36).ToString().Substring(0, 16));
                    // Mex and XB are hotfixes for Fruit 2016. Remove in future.
                    shCountry.Add(reader.GetValue(44).ToString().Trim().Replace("Mex", "MX").Replace("XB", "XK"));   // Trim() removes trailing white-spaces
                    shType.Add("Onsite");
                }
                conn.Close();
                Console.WriteLine("Current Connection State: " + conn.State.ToString());
            }
            catch (AdsException ex)
            {   // print the exception message
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error while reading HotMax data");
            }

            /* Now read EKS data */
            lblStatus.Text = "Reading EKS Exports...";
            Application.DoEvents();
            bool addCode;
            foreach (string eksFileName in Directory.GetFiles(txtEKSDir.Text, "*.csv"))
            {
                try
                {
                    Console.WriteLine("Reading: " + eksFileName);
                    using (StreamReader sre = new StreamReader(eksFileName))
                    {
                        string eksLine;
                        string[] eksValues;
                        while (!sre.EndOfStream)
                        {
                            addCode = false;
                            eksLine = sre.ReadLine();       // from 1st line on, but we only compare barcodes
                            eksValues = eksLine.Split(';');
                            if (string.Compare(eksValues[21], "1", true) == 0   // column "Eingetreten"
                                && string.Compare(eksValues[13].Substring(0, 3), lstSeasons.SelectedItem.ToString().Substring(0, 3), true) == 0)
                            {
                                if (chkExhibitor.Checked && eksValues[14][4] == 'A')
                                {
                                    addCode = true;
                                }
                                else if (chkTrade.Checked && eksValues[14][4] == 'F')
                                {
                                    addCode = true;
                                }
                                else if (chkPress.Checked && eksValues[14][4] == 'M')
                                {
                                    addCode = true;
                                }
                                else if (chkPrivate.Checked && eksValues[14][4] == 'P')
                                {
                                    addCode = true;
                                }
                                else if (chkOther.Checked && eksValues[14][4] == 'S')
                                {
                                    addCode = true;
                                }
                                if (addCode)
                                {
                                    eksBarcode.Add(eksValues[0].Substring(0, 16));
                                }
                                /*
                                else
                                {
                                    Console.WriteLine("Barcode " + eksValues[0] + " not imported from EKS.");
                                }
                                */
                            }
                        }
                        Console.WriteLine("EKS records imported: " + eksBarcode.Count);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The EKS file could not be read:");
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "The file could not be read");
                }
            }

            /* Create merged data */
            lblStatus.Text = "Calculating Result...";
            Application.DoEvents();
            StringBuilder sb = new StringBuilder();
            CountryDictData.generateDict();
            SortedDictionary<string, int[]> countLaender = new SortedDictionary<string, int[]>();   // <Country, {counterOnsite, counterOnline}>
            sb.AppendLine("LandKurz;Land;Anzahl Onsite;Anzahl Online;Summe pro Land;Prozent an Gesamt");
            int bcDone = 0;     // counter for status label
            /* TODO: Refactor this part maybe. */
            if (chkDistinctBarcode.Checked)
            {
                foreach (string bc in shBarcode)
                {
                    if (bcDone % 1000 == 0)     // refresh status label every 1000 processed records
                    {
                        lblStatus.Text = "Merging data... (" + bcDone + "/" + shBarcode.Count + ")";
                        Application.DoEvents();
                    }
                    if (eksBarcode.Contains(bc) && !mergedBarcode.Contains(bc))     // each barcode once
                    {
                        mergedBarcode.Add(bc);
                        /* If country code is in dictionary, add it, else add "ZZ" */
                        if (shCountry[shBarcode.IndexOf(bc)].Length == 2)
                        {
                            if (CountryDictData.nameLaender.ContainsKey(shCountry[shBarcode.IndexOf(bc)]))
                            {
                                mergedCountry.Add(shCountry[shBarcode.IndexOf(bc)]);
                            }
                            else
                            {
                                mergedCountry.Add("ZZ");
                                Console.WriteLine("Unknown: " + shCountry[shBarcode.IndexOf(bc)]);
                            }
                        }
                        /* If not country code, but full name, lookup the code in dict and add it */
                        else if (shCountry[shBarcode.IndexOf(bc)].Length > 1)
                        {
                            if (CountryDictData.nameLaender.ContainsKey(shCountry[shBarcode.IndexOf(bc)]))
                            {
                                mergedCountry.Add(CountryDictData.nameLaender[shCountry[shBarcode.IndexOf(bc)]]);
                            }
                            else
                            {
                                mergedCountry.Add("ZZ");
                                Console.WriteLine("Unknown: " + shCountry[shBarcode.IndexOf(bc)] + " (line " + shBarcode.IndexOf(bc) + ")");
                            }
                        }
                        mergedType.Add(shType[shBarcode.IndexOf(bc)]);
                    }
                    bcDone++;
                }
            }
            else
            {   // The same thing, just wihout checking for distinct barcodes.
                // This time we're going from EKS to SH (faster).
                foreach (string bc in eksBarcode)
                {
                    if (bcDone % 1000 == 0)
                    {
                        lblStatus.Text = "Merging data... (" + bcDone + "/" + eksBarcode.Count + ")";
                        Application.DoEvents();
                    }
                    if (shBarcode.Contains(bc))
                    {
                        mergedBarcode.Add(bc);
                        if (shCountry[shBarcode.IndexOf(bc)].Length == 2)
                        {
                            if (CountryDictData.nameLaender.ContainsKey(shCountry[shBarcode.IndexOf(bc)]))
                            {
                                mergedCountry.Add(shCountry[shBarcode.IndexOf(bc)]);
                            }
                            else
                            {
                                mergedCountry.Add("ZZ");
                                Console.WriteLine("Unknown: " + shCountry[shBarcode.IndexOf(bc)]);
                            }
                        }
                        else if (shCountry[shBarcode.IndexOf(bc)].Length > 1)
                        {
                            if (CountryDictData.nameLaender.ContainsKey(shCountry[shBarcode.IndexOf(bc)]))
                            {
                                mergedCountry.Add(CountryDictData.nameLaender[shCountry[shBarcode.IndexOf(bc)]]);
                            }
                            else
                            {
                                mergedCountry.Add("ZZ");
                                Console.WriteLine("Unknown: " + shCountry[shBarcode.IndexOf(bc)] + " (line " + shBarcode.IndexOf(bc) + ")");
                            }
                        }
                        mergedType.Add(shType[shBarcode.IndexOf(bc)]);
                    }
                    bcDone++;
                }
            }
            Console.WriteLine("Merged " + mergedBarcode.Count + " barcodes.");
            int total = 0;
            for (int i = 0; i < mergedCountry.Count; i++)
            {
                /* If we haven't seen this country before, add it to dictionary */
                if (!countLaender.ContainsKey(mergedCountry[i]))
                {
                    if (string.Compare(mergedType[i], "Onsite", true) == 0)
                    {
                        countLaender.Add(mergedCountry[i], new[] { 1, 0 });
                    }
                    else if (string.Compare(mergedType[i], "Online", true) == 0)
                    {
                        countLaender.Add(mergedCountry[i], new[] { 0, 1 });
                    }
                    total++;
                }
                else
                {
                    if (string.Compare(mergedType[i], "Onsite", true) == 0)
                    {
                        countLaender[mergedCountry[i]][0]++;
                    }
                    else if (string.Compare(mergedType[i], "Online", true) == 0)
                    {
                        countLaender[mergedCountry[i]][1]++;
                    }
                    total++;
                }
            }
            string htmlMap = "";
            if (chkShowMap.Checked)
            {
                // Google Charts Map
                htmlMap =
                    "<!DOCTYPE html>\n" +
                    "<html>\n" +
                    "<head>\n" +
                    "<script type=\"text/javascript\" src=\"https://www.google.com/jsapi\"></script>\n" +
                    "<script type=\"text/javascript\">\n" +
                    "google.load(\"visualization\", \"1\", {packages:[\"geochart\"]});\n" +
                    "google.setOnLoadCallback(drawRegionsMap);\n" +
                    "function drawRegionsMap() {\n" +
                    "var data = google.visualization.arrayToDataTable([\n" +
                    "['Country', 'Visitors', 'Percentage']";
            }
            decimal percent;
            int sum;            // Onsite + Online per country
            int sumOnsite = 0;  // Total Onsite
            int sumOnline = 0;  // Total Online
            foreach (string cc in countLaender.Keys)
            {
                /* If valid country code, append a line with number of SecuTix and HotMax hits */
                if (cc.Length > 1)
                {
                    sum = countLaender[cc][0] + countLaender[cc][1];
                    sumOnsite += countLaender[cc][0];
                    sumOnline += countLaender[cc][1];
                    percent = Math.Round((decimal)sum * 10000 / total) / 100;
                    Console.WriteLine(cc);
                    sb.AppendLine(cc + ";"
                        + CountryDictData.nameLaender[cc] + ";"
                        + countLaender[cc][0] + ";"
                        + countLaender[cc][1] + ";"
                        + sum + ";"
                        + percent + "%");
                    if (chkShowMap.Checked && chkExcludeDE.Checked)
                    {
                        if (string.Compare(cc, "DE", true) != 0)
                        {
                            htmlMap += ",\n['" + cc + "', " + sum + ", " + percent.ToString().Replace(",", ".") + "]";
                        }
                    }
                    else if (chkShowMap.Checked)
                    {
                        htmlMap += ",\n['" + cc + "', " + sum + ", " + percent.ToString().Replace(",", ".") + "]";
                    }
                }
            }
            sb.AppendLine("Summe;;" + sumOnsite + ";" + sumOnline + ";" + (sumOnsite + sumOnline) + ";100,00%");
            /* Write the stream contents to a new file */
            if (sumOnsite > 0 || sumOnline > 0)
            {
                Console.WriteLine("Onsite: " + sumOnsite);
                Console.WriteLine("Online: " + sumOnline);
                using (StreamWriter outfile = new StreamWriter(txtCSVOut.Text))
                {
                    outfile.Write(sb.ToString());
                }
                if (chkShowMap.Checked)
                {
                    htmlMap +=
                        "\n]);\n" +
                        "var options = {\n";
                    if (chkIE9.Checked)
                    {
                        // tooltip:{textStyle:{color:'black',fontName:<global-font-name>,fontSize:<global-font-size>}}
                        htmlMap += "tooltip:{textStyle:{bold:false}}\n";
                    }
                    htmlMap +=
                        "};\n" +
                        "var chart = new google.visualization.GeoChart(document.getElementById('regions_div'));\n" +
                        "chart.draw(data, options);\n" +
                        "}\n" +
                        "</script>\n" +
                        "</head>\n" +
                        "<body>\n" +
                        "<div id=\"regions_div\" style=\"width: 900px; height: 500px; \"></div>\n" +
                        "</body>\n" +
                        "</html>";
                    string htmlFile = "Map_" + lstSeasons.SelectedItem.ToString().Replace(" ", "_").Replace("/", "_") + ".html";
                    File.WriteAllText(htmlFile, htmlMap);   // save in same directory
                    System.Diagnostics.Process.Start(htmlFile);
                }
                lblStatus.Text = "All done.";
                Application.DoEvents();
                MessageBox.Show("Operation completed.");
            }
            else
            {
                lblStatus.Text = "No records found.";
                Application.DoEvents();
                MessageBox.Show("Something went wrong.\nNo records were found.");
            }
            btnStart.Enabled = true;
        }

        private void lstSaisons_SelectedIndexChanged(object sender, EventArgs e)
        {
            preflight();
        }

        /* Check whether all directories are distinct */
        private bool validDir()
        {
            if (string.Compare(txtSecutix360Dir.Text, txtSecutixOneDir.Text, true) == 0 && (txtSecutix360Dir.TextLength > 0 && txtSecutixOneDir.TextLength > 0)
                    || string.Compare(txtSecutix360Dir.Text, txtEKSDir.Text, true) == 0 && (txtSecutix360Dir.TextLength > 0 && txtEKSDir.TextLength > 0)
                    || string.Compare(txtSecutixOneDir.Text, txtEKSDir.Text, true) == 0 && (txtSecutixOneDir.TextLength > 0 && txtEKSDir.TextLength > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /* Check whether all directories etc. are valid and enable Start button */
        private void preflight()
        {
            int error = 0;
            error += (txtSecutix360Dir.TextLength > 0) ? 0 : 1;
            error += (txtSecutixOneDir.TextLength > 0) ? 0 : 1;
            error += (txtEKSDir.TextLength > 0) ? 0 : 1;
            error += (txtHotmaxPath.TextLength > 0) ? 0 : 1;
            error += (txtCSVOut.TextLength > 0) ? 0 : 1;
            error += (lstSeasons.SelectedItems.Count > 0) ? 0 : 1;
            error += (string.Compare(txtSecutix360Dir.Text, txtSecutixOneDir.Text, true) != 0) ? 0 : 1;
            error += (string.Compare(txtSecutix360Dir.Text, txtEKSDir.Text, true) != 0) ? 0 : 1;
            error += (string.Compare(txtSecutixOneDir.Text, txtEKSDir.Text, true) != 0) ? 0 : 1;
            btnStart.Enabled = (error == 0) ? true : false;
        }

        private void chkShowMap_CheckedChanged(object sender, EventArgs e)
        {
            chkExcludeDE.Enabled = (chkShowMap.Checked) ? true : false;
            chkIE9.Enabled = (chkShowMap.Checked) ? true : false;
        }
    }
}
