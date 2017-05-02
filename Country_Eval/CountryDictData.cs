﻿using System.Collections.Generic;

namespace Country_Eval
{
    class CountryDictData
    {
        public static Dictionary<string, string> nameLaender = new Dictionary<string, string>();  // <ShortName, LongName> AND <LongName, ShortName>

        public static void generateDict()
        {
            // HotMax, SecuTix, Output
            nameLaender.Add("AD", "Andorra");
            nameLaender.Add("AE", "Vereinigte Arabische Emirate");
            nameLaender.Add("AF", "Afghanistan");
            nameLaender.Add("AG", "Antigua/Barbuda");
            nameLaender.Add("AI", "Anguilla");
            nameLaender.Add("AL", "Albanien");
            nameLaender.Add("AM", "Armenien");
            nameLaender.Add("AN", "Niederländische Antillen");
            nameLaender.Add("AO", "Angola");
            nameLaender.Add("AQ", "Antarktis");
            nameLaender.Add("AR", "Argentinien");
            nameLaender.Add("AS", "Samoa, American");
            nameLaender.Add("AT", "Österreich");
            nameLaender.Add("AU", "Australien");
            nameLaender.Add("AW", "Aruba");
            nameLaender.Add("AX", "Aland");
            nameLaender.Add("AZ", "Aserbaidschan");
            nameLaender.Add("BA", "Bosnien und Herzegowina");
            nameLaender.Add("BB", "Barbados");
            nameLaender.Add("BD", "Bangladesch");
            nameLaender.Add("BE", "Belgien");
            nameLaender.Add("BF", "Burkina-Faso");
            nameLaender.Add("BG", "Bulgarien");
            nameLaender.Add("BH", "Bahrain");
            nameLaender.Add("BI", "Burundi");
            nameLaender.Add("BJ", "Benin");
            nameLaender.Add("BL", "St. Barthelemy");
            nameLaender.Add("BM", "Bermuda");
            nameLaender.Add("BN", "Brunei Darussalam");
            nameLaender.Add("BO", "Bolivien");
            nameLaender.Add("BQ", "Bonaire, Saba");
            nameLaender.Add("BR", "Brasilien");
            nameLaender.Add("BS", "Bahamas");
            nameLaender.Add("BT", "Bhutan");
            nameLaender.Add("BV", "Bouvet Inseln");
            nameLaender.Add("BW", "Botsuana");
            nameLaender.Add("BY", "Belarus");
            nameLaender.Add("BZ", "Belize");
            nameLaender.Add("CA", "Kanada");
            nameLaender.Add("CC", "Kokosinseln");
            nameLaender.Add("CD", "Demokratische Republik Kongo");
            nameLaender.Add("CF", "Zentralafrikanische Republik");
            nameLaender.Add("CG", "Republik Kongo");
            nameLaender.Add("CH", "Schweiz");
            nameLaender.Add("CI", "Côte d´Ivoire");
            nameLaender.Add("CK", "Cookinseln");
            nameLaender.Add("CL", "Chile");
            nameLaender.Add("CM", "Kamerun");
            nameLaender.Add("CN", "China");
            nameLaender.Add("CO", "Kolumbien");
            nameLaender.Add("CR", "Costa Rica");
            nameLaender.Add("CU", "Kuba");
            nameLaender.Add("CV", "Kap Verde");
            nameLaender.Add("CW", "Curacao");
            nameLaender.Add("CX", "Weihnachtsinsel");
            nameLaender.Add("CY", "Zypern");
            nameLaender.Add("CZ", "Tschechische Republik");
            nameLaender.Add("DE", "Deutschland");
            nameLaender.Add("DJ", "Dschibuti");
            nameLaender.Add("DK", "Dänemark");
            nameLaender.Add("DM", "Dominica");
            nameLaender.Add("DO", "Dominikanische Republik");
            nameLaender.Add("DZ", "Algerien");
            nameLaender.Add("EC", "Ecuador");
            nameLaender.Add("EE", "Estland");
            nameLaender.Add("EG", "Ägypten");
            nameLaender.Add("EH", "West Sahara");
            nameLaender.Add("ER", "Eritrea");
            nameLaender.Add("ES", "Spanien");
            nameLaender.Add("ET", "Äthiopien");
            nameLaender.Add("FI", "Finnland");
            nameLaender.Add("FJ", "Fidschi");
            nameLaender.Add("FK", "Falklandinseln");
            nameLaender.Add("FM", "Mikronesien");
            nameLaender.Add("FO", "Färöer");
            nameLaender.Add("FR", "Frankreich");
            nameLaender.Add("GA", "Gabun");
            nameLaender.Add("GB", "United Kingdom");
            nameLaender.Add("GD", "Grenada");
            nameLaender.Add("GE", "Georgien");
            nameLaender.Add("GF", "Französisch Guayana");
            nameLaender.Add("GG", "Guernsey");
            nameLaender.Add("GH", "Ghana");
            nameLaender.Add("GI", "Gibraltar");
            nameLaender.Add("GL", "Grönland");
            nameLaender.Add("GM", "Gambia");
            nameLaender.Add("GN", "Guinea");
            nameLaender.Add("GP", "Guadeloupe");
            nameLaender.Add("GQ", "Äquatorialguine");
            nameLaender.Add("GR", "Griechenland");
            nameLaender.Add("GS", "Südliche Sandwich Inseln");
            nameLaender.Add("GT", "Guatemala");
            nameLaender.Add("GU", "Guam");
            nameLaender.Add("GW", "Guinea-Bissau");
            nameLaender.Add("GY", "Guyana");
            nameLaender.Add("HK", "Hongkong");
            nameLaender.Add("HM", "Heard und McDonaldinseln");
            nameLaender.Add("HN", "Honduras");
            nameLaender.Add("HR", "Kroatien");
            nameLaender.Add("HT", "Haiti");
            nameLaender.Add("HU", "Ungarn");
            nameLaender.Add("ID", "Indonesien");
            nameLaender.Add("IE", "Irland");
            nameLaender.Add("IL", "Israel");
            nameLaender.Add("IM", "Isle of Man");
            nameLaender.Add("IN", "Indien");
            nameLaender.Add("IO", "Brit.Geb.im Indischen Ozean");
            nameLaender.Add("IQ", "Irak");
            nameLaender.Add("IR", "Iran");
            nameLaender.Add("IS", "Island");
            nameLaender.Add("IT", "Italien");
            nameLaender.Add("JE", "Jersey");
            nameLaender.Add("JM", "Jamaika");
            nameLaender.Add("JO", "Jordanien");
            nameLaender.Add("JP", "Japan");
            nameLaender.Add("KE", "Kenia");
            nameLaender.Add("KG", "Kirgisistan");
            nameLaender.Add("KH", "Kambodscha");
            nameLaender.Add("KI", "Kiribati");
            nameLaender.Add("KM", "Komoren");
            nameLaender.Add("KN", "St.Kitts&Nevis");
            nameLaender.Add("KO", "Kosovo");
            nameLaender.Add("KP", "Nordkorea");
            nameLaender.Add("KR", "Südkorea");
            nameLaender.Add("KW", "Kuwait");
            nameLaender.Add("KY", "Kaimaninseln");
            nameLaender.Add("KZ", "Kasachstan");
            nameLaender.Add("LA", "Laos");
            nameLaender.Add("LB", "Libanon");
            nameLaender.Add("LC", "St. Lucia");
            nameLaender.Add("LI", "Liechtenstein");
            nameLaender.Add("LK", "Sri Lanka");
            nameLaender.Add("LR", "Liberia");
            nameLaender.Add("LS", "Lesotho");
            nameLaender.Add("LT", "Litauen");
            nameLaender.Add("LU", "Luxemburg");
            nameLaender.Add("LV", "Lettland");
            nameLaender.Add("LY", "Libyen");
            nameLaender.Add("MA", "Marokko");
            nameLaender.Add("MC", "Monaco");
            nameLaender.Add("MD", "Moldau");
            nameLaender.Add("ME", "Montenegro");
            nameLaender.Add("MF", "St. Martin(fr.)");
            nameLaender.Add("MG", "Madagaskar");
            nameLaender.Add("MH", "Marshall-Inseln");
            nameLaender.Add("MK", "Mazedonien");
            nameLaender.Add("ML", "Mali");
            nameLaender.Add("MM", "Myanmar");
            nameLaender.Add("MN", "Mongolei");
            nameLaender.Add("MO", "Macau");
            nameLaender.Add("MP", "Nördl. Marianen");
            nameLaender.Add("MQ", "Martinique");
            nameLaender.Add("MR", "Mauretanien");
            nameLaender.Add("MS", "Montserrat");
            nameLaender.Add("MT", "Malta");
            nameLaender.Add("MU", "Mauritius");
            nameLaender.Add("MV", "Malediven");
            nameLaender.Add("MW", "Malawi");
            nameLaender.Add("MX", "Mexiko");
            nameLaender.Add("MY", "Malaysia");
            nameLaender.Add("MZ", "Mosambik");
            nameLaender.Add("NA", "Namibia");
            nameLaender.Add("NC", "Neukaledonien");
            nameLaender.Add("NE", "Niger");
            nameLaender.Add("NF", "Norfolkinseln");
            nameLaender.Add("NG", "Nigeria");
            nameLaender.Add("NI", "Nicaragua");
            nameLaender.Add("NL", "Niederlande");
            nameLaender.Add("NO", "Norwegen");
            nameLaender.Add("NP", "Nepal");
            nameLaender.Add("NR", "Nauru");
            nameLaender.Add("NU", "Niue-Inseln");   // Niue is a single island...
            nameLaender.Add("NZ", "Neuseeland");
            nameLaender.Add("OM", "Oman");
            nameLaender.Add("PA", "Panama");
            nameLaender.Add("PE", "Peru");
            nameLaender.Add("PF", "Französisch-Polynesien");
            nameLaender.Add("PG", "Papua-Neuguinea");
            nameLaender.Add("PH", "Philippinen");
            nameLaender.Add("PK", "Pakistan");
            nameLaender.Add("PL", "Polen");
            nameLaender.Add("PM", "StPier.,Miquel.");
            nameLaender.Add("PN", "Pitcairn Inseln");
            nameLaender.Add("PR", "Puerto Rico");
            nameLaender.Add("PS", "Palästinensische Autonomiegebiete");
            nameLaender.Add("PT", "Portugal");
            nameLaender.Add("PW", "Palau");
            nameLaender.Add("PY", "Paraguay");
            nameLaender.Add("QA", "Katar");
            nameLaender.Add("RE", "Reunion");
            nameLaender.Add("RO", "Rumänien");
            nameLaender.Add("RS", "Serbien");
            nameLaender.Add("RU", "Russische Föderation");
            nameLaender.Add("RW", "Ruanda");
            nameLaender.Add("SA", "Saudi-Arabien");
            nameLaender.Add("SB", "Salomonen");
            nameLaender.Add("SC", "Seychellen");
            nameLaender.Add("SD", "Sudan");
            nameLaender.Add("SE", "Schweden");
            nameLaender.Add("SG", "Singapur");
            nameLaender.Add("SH", "St. Helena");
            nameLaender.Add("SI", "Slowenien");
            nameLaender.Add("SJ", "Svalbard");
            nameLaender.Add("SK", "Slowakei");
            nameLaender.Add("SL", "Sierra Leone");
            nameLaender.Add("SM", "San Marino");
            nameLaender.Add("SN", "Senegal");
            nameLaender.Add("SO", "Somalia");
            nameLaender.Add("SR", "Suriname");
            nameLaender.Add("SS", "Süd Sudan");
            nameLaender.Add("ST", "Sao Tome und Principe");
            nameLaender.Add("SV", "El Salvador");
            nameLaender.Add("SX", "St. Martin(nl.)");
            nameLaender.Add("SY", "Syrien");
            nameLaender.Add("SZ", "Swasiland");
            nameLaender.Add("TC", "Turks-,Caicosin");
            nameLaender.Add("TD", "Tschad");
            nameLaender.Add("TF", "Französische Süd- und Antarktisgebiete");
            nameLaender.Add("TG", "Togo");
            nameLaender.Add("TH", "Thailand");
            nameLaender.Add("TJ", "Tadschikistan");
            nameLaender.Add("TK", "Tokelau-Inseln");
            nameLaender.Add("TL", "Timor-Leste");
            nameLaender.Add("TM", "Turkmenistan");
            nameLaender.Add("TN", "Tunesien");
            nameLaender.Add("TO", "Tonga");
            nameLaender.Add("TP", "Ost Timor");
            nameLaender.Add("TR", "Türkei");
            nameLaender.Add("TT", "Trinidad,Tobago");
            nameLaender.Add("TV", "Tuvalu");
            nameLaender.Add("TW", "Taiwan");
            nameLaender.Add("TZ", "Tansania");
            nameLaender.Add("UA", "Ukraine");
            nameLaender.Add("UG", "Uganda");
            nameLaender.Add("UM", "Minor Outlying Islands");
            nameLaender.Add("US", "USA");
            nameLaender.Add("UY", "Uruguay");
            nameLaender.Add("UZ", "Usbekistan");
            nameLaender.Add("VA", "Vatikanstadt");
            nameLaender.Add("VC", "St. Vincent");
            nameLaender.Add("VE", "Venezuela");
            nameLaender.Add("VG", "Britische Jungferninseln");
            nameLaender.Add("VI", "Amerikanische Jungferninseln");
            nameLaender.Add("VN", "Vietnam");
            nameLaender.Add("VU", "Vanuatu");
            nameLaender.Add("WF", "Wallis,Futuna");
            nameLaender.Add("WS", "Westsamoa");
            nameLaender.Add("XK", "Kosovo");
            nameLaender.Add("YE", "Jemen");
            nameLaender.Add("YT", "Mayotte");
            nameLaender.Add("ZA", "Südafrika");
            nameLaender.Add("ZM", "Sambia");
            nameLaender.Add("ZW", "Simbabwe");
            nameLaender.Add("ZZ", "_UNKNOWN");
            // SecuTix 360
            nameLaender.Add("Andorra", "AD");
            nameLaender.Add("Vereinigte Arabische Emirate", "AE");
            nameLaender.Add("Afghanistan", "AF");
            nameLaender.Add("Antigua und Barbuda", "AG");
            nameLaender.Add("Antigua/Barbuda", "AG");
            nameLaender.Add("Anguilla", "AI");
            nameLaender.Add("Albanien", "AL");
            nameLaender.Add("Armenien", "AM");
            nameLaender.Add("Niederländische Antillen", "AN");
            nameLaender.Add("Angola", "AO");
            nameLaender.Add("Antarktika", "AQ");
            nameLaender.Add("Antarktis", "AQ");
            nameLaender.Add("Argentinien", "AR");
            nameLaender.Add("Samoa Américaines", "AS");
            nameLaender.Add("Samoa, American", "AS");
            nameLaender.Add("Österreich", "AT");
            nameLaender.Add("Australien", "AU");
            nameLaender.Add("Aruba", "AW");
            nameLaender.Add("Aland", "AX");
            nameLaender.Add("Aserbaidschan", "AZ");
            nameLaender.Add("Bosnien Herzegowina", "BA");
            nameLaender.Add("Bosnien und Herzegowina", "BA");
            nameLaender.Add("Barbados", "BB");
            nameLaender.Add("Bangladesch", "BD");
            nameLaender.Add("Bangladesh", "BD");
            nameLaender.Add("Belgien", "BE");
            nameLaender.Add("Burkina Faso", "BF");
            nameLaender.Add("Burkina-Faso", "BF");
            nameLaender.Add("Bulgarien", "BG");
            nameLaender.Add("Bahrain", "BH");
            nameLaender.Add("Burundi", "BI");
            nameLaender.Add("Benin", "BJ");
            nameLaender.Add("St. Barthelemy", "BL");
            nameLaender.Add("Bermuda", "BM");
            nameLaender.Add("Brunei Darussalam", "BN");
            nameLaender.Add("Bolivien", "BO");
            nameLaender.Add("Bonaire, Saba", "BQ");
            nameLaender.Add("Brasilien", "BR");
            nameLaender.Add("Bahamas", "BS");
            nameLaender.Add("Bhutan", "BT");
            nameLaender.Add("Bouvet Inseln", "BV");
            nameLaender.Add("Botswana", "BW");
            nameLaender.Add("Botsuana", "BW");
            nameLaender.Add("Belarus (Weissrussland)", "BY");
            nameLaender.Add("Belarus", "BY");
            nameLaender.Add("Belize", "BZ");
            nameLaender.Add("Kanada", "CA");
            nameLaender.Add("Kokosinseln", "CC");
            nameLaender.Add("Kongo, Demokratische Republik (ehem. Zaire)", "CD");
            nameLaender.Add("Demokratische Republik Kongo", "CD");
            nameLaender.Add("Zentralafrikanische Republik", "CF");
            nameLaender.Add("Republik Kongo", "CG");
            nameLaender.Add("Schweiz", "CH");
            nameLaender.Add("Elfenbeinküste", "CI");
            nameLaender.Add("Côte d´Ivoire", "CI");
            nameLaender.Add("Cookinseln", "CK");
            nameLaender.Add("Chile", "CL");
            nameLaender.Add("Kamerun", "CM");
            nameLaender.Add("China", "CN");
            nameLaender.Add("Kolumbien", "CO");
            nameLaender.Add("Costa Rica", "CR");
            nameLaender.Add("Kuba", "CU");
            nameLaender.Add("Cap Verde", "CV");
            nameLaender.Add("Kap Verde", "CV");
            nameLaender.Add("Curacao", "CW");
            nameLaender.Add("Weihnachtsinsel", "CX");
            nameLaender.Add("Zypern", "CY");
            nameLaender.Add("Tschechische Republik", "CZ");
            nameLaender.Add("Deutschland", "DE");
            nameLaender.Add("Dschibuti", "DJ");
            nameLaender.Add("Dänemark", "DK");
            nameLaender.Add("Dominica", "DM");
            nameLaender.Add("Dominikanische Republik", "DO");
            nameLaender.Add("Algerien", "DZ");
            nameLaender.Add("Ecuador", "EC");
            nameLaender.Add("Estland", "EE");
            nameLaender.Add("Ägypten", "EG");
            nameLaender.Add("West Sahara", "EH");
            nameLaender.Add("Eritrea", "ER");
            nameLaender.Add("Spanien", "ES");
            nameLaender.Add("Äthiopien", "ET");
            nameLaender.Add("Finnland", "FI");
            nameLaender.Add("Fidschi", "FJ");
            nameLaender.Add("Falklandinseln", "FK");
            nameLaender.Add("Mikronesien", "FM");
            nameLaender.Add("Färöer", "FO");
            nameLaender.Add("Frankreich", "FR");
            nameLaender.Add("Gabun", "GA");
            nameLaender.Add("United Kingdom", "GB");
            nameLaender.Add("Vereinigtes Königreich", "GB");
            nameLaender.Add("Grenada", "GD");
            nameLaender.Add("Georgien", "GE");
            nameLaender.Add("Französisch-Guyana", "GF");
            nameLaender.Add("Französisch Guayana", "GF");
            nameLaender.Add("Guernsey (Kanalinsel)", "GG");
            nameLaender.Add("Guernsey", "GG");
            nameLaender.Add("Ghana", "GH");
            nameLaender.Add("Gibraltar", "GI");
            nameLaender.Add("Grönland", "GL");
            nameLaender.Add("Gambia", "GM");
            nameLaender.Add("Guinea", "GN");
            nameLaender.Add("Guadeloupe", "GP");
            nameLaender.Add("Äquatorialguinea", "GQ");
            nameLaender.Add("Äquatorialguine", "GQ");
            nameLaender.Add("Griechenland", "GR");
            nameLaender.Add("Südliche Sandwich Inseln", "GS");
            nameLaender.Add("Guatemala", "GT");
            nameLaender.Add("Guam", "GU");
            nameLaender.Add("Guinea-Bissau", "GW");
            nameLaender.Add("Guyana", "GY");
            nameLaender.Add("Hongkong", "HK");
            nameLaender.Add("Heard und McDonaldinseln", "HM");
            nameLaender.Add("Honduras", "HN");
            nameLaender.Add("Kroatien", "HR");
            nameLaender.Add("Haiti", "HT");
            nameLaender.Add("Ungarn", "HU");
            nameLaender.Add("Indonesien", "ID");
            nameLaender.Add("Irland", "IE");
            nameLaender.Add("Israel", "IL");
            nameLaender.Add("Isle of Man", "IM");
            nameLaender.Add("Indien", "IN");
            nameLaender.Add("Britisches Territorium im Indischen Ozean", "IO");
            nameLaender.Add("Brit.Geb.im Indischen Ozean", "IO");
            nameLaender.Add("Irak", "IQ");
            nameLaender.Add("Iran (Islamische Republik)", "IR");
            nameLaender.Add("Iran", "IR");
            nameLaender.Add("Island", "IS");
            nameLaender.Add("Italien", "IT");
            nameLaender.Add("Jersey", "JE");
            nameLaender.Add("Jamaika", "JM");
            nameLaender.Add("Jordanien", "JO");
            nameLaender.Add("Japan", "JP");
            nameLaender.Add("Kenia", "KE");
            nameLaender.Add("Kirgisistan", "KG");
            nameLaender.Add("Kambodscha", "KH");
            nameLaender.Add("Kiribati", "KI");
            nameLaender.Add("Komoron", "KM");
            nameLaender.Add("St. Kitts und Nevis", "KN");
            nameLaender.Add("St.Kitts&Nevis", "KN");
            nameLaender.Add("Korea (Nord)", "KP");
            nameLaender.Add("Nordkorea", "KP");
            nameLaender.Add("Korea (Süd)", "KR");
            nameLaender.Add("Südkorea", "KR");
            nameLaender.Add("Kuwait", "KW");
            nameLaender.Add("Kaimaninseln", "KY");
            nameLaender.Add("Kasachstan", "KZ");
            nameLaender.Add("Laos", "LA");
            nameLaender.Add("Libanon", "LB");
            nameLaender.Add("St. Lucia", "LC");
            nameLaender.Add("Liechtenstein", "LI");
            nameLaender.Add("Sri Lanka", "LK");
            nameLaender.Add("Liberia", "LR");
            nameLaender.Add("Lesotho", "LS");
            nameLaender.Add("Litauen", "LT");
            nameLaender.Add("Luxemburg", "LU");
            nameLaender.Add("Lettland", "LV");
            nameLaender.Add("Libyen", "LY");
            nameLaender.Add("Marokko", "MA");
            nameLaender.Add("Monaco", "MC");
            nameLaender.Add("Moldavien", "MD");
            nameLaender.Add("Moldau", "MD");
            nameLaender.Add("Montenegro", "ME");
            nameLaender.Add("St. Martin(fr.)", "MF");
            nameLaender.Add("Madagaskar", "MG");
            nameLaender.Add("Marshallinseln", "MH");
            nameLaender.Add("Marshall-Inseln", "MH");
            nameLaender.Add("Mazedonien", "MK");
            nameLaender.Add("Mali", "ML");
            nameLaender.Add("Myanmar (Burma)", "MM");
            nameLaender.Add("Myanmar", "MM");
            nameLaender.Add("Mongolei", "MN");
            nameLaender.Add("Macao", "MO");
            nameLaender.Add("Nördliche Marianen", "MP");
            nameLaender.Add("Nördl. Marianen", "MP");
            nameLaender.Add("Martinique", "MQ");
            nameLaender.Add("Mauretanien", "MR");
            nameLaender.Add("Montserrat", "MS");
            nameLaender.Add("Malta", "MT");
            nameLaender.Add("Mauritius", "MU");
            nameLaender.Add("Malediven", "MV");
            nameLaender.Add("Malawi", "MW");
            nameLaender.Add("Mexiko", "MX");
            nameLaender.Add("Malaysia", "MY");
            nameLaender.Add("Mosambik", "MZ");
            nameLaender.Add("Namibia", "NA");
            nameLaender.Add("Neukaledonien", "NC");
            nameLaender.Add("Niger", "NE");
            nameLaender.Add("Norfolkinseln", "NF");
            nameLaender.Add("Nigeria", "NG");
            nameLaender.Add("Nicaragua", "NI");
            nameLaender.Add("Niederlande", "NL");
            nameLaender.Add("Norwegen", "NO");
            nameLaender.Add("Nepal", "NP");
            nameLaender.Add("Nauru", "NR");
            nameLaender.Add("Niue", "NU");
            nameLaender.Add("Niue-Inseln", "NU");
            nameLaender.Add("Neuseeland", "NZ");
            nameLaender.Add("Oman", "OM");
            nameLaender.Add("Panama", "PA");
            nameLaender.Add("Peru", "PE");
            nameLaender.Add("Französisch-Polynesien", "PF");
            nameLaender.Add("Papua-Neuguinea", "PG");
            nameLaender.Add("Philippinen", "PH");
            nameLaender.Add("Pakistan", "PK");
            nameLaender.Add("Polen", "PL");
            nameLaender.Add("St. Pierre und Miquelon", "PM");
            nameLaender.Add("StPier.,Miquel.", "PM");
            nameLaender.Add("Pitcairninseln", "PN");
            nameLaender.Add("Pitcairn Inseln", "PN");
            nameLaender.Add("Puerto Rico", "PR");
            nameLaender.Add("Palästinensische Autonomiegebiete", "PS");
            nameLaender.Add("Portugal", "PT");
            nameLaender.Add("Palau", "PW");
            nameLaender.Add("Paraguay", "PY");
            nameLaender.Add("Katar", "QA");
            nameLaender.Add("Reunion", "RE");
            nameLaender.Add("Rumänien", "RO");
            nameLaender.Add("Serbien", "RS");
            nameLaender.Add("Russische Föderation", "RU");
            nameLaender.Add("Ruanda", "RW");
            nameLaender.Add("Saudi-Arabien", "SA");
            nameLaender.Add("Salomonen", "SB");
            nameLaender.Add("Seychellen", "SC");
            nameLaender.Add("Sudan", "SD");
            nameLaender.Add("Schweden", "SE");
            nameLaender.Add("Singapur", "SG");
            nameLaender.Add("St. Helena", "SH");
            nameLaender.Add("Slovenien", "SI");
            nameLaender.Add("Slowenien", "SI");
            nameLaender.Add("Svalbard", "SJ");
            nameLaender.Add("Slovakei", "SK");
            nameLaender.Add("Slowakei", "SK");
            nameLaender.Add("Sierra Leone", "SL");
            nameLaender.Add("San Marino", "SM");
            nameLaender.Add("Senegal", "SN");
            nameLaender.Add("Somalia", "SO");
            nameLaender.Add("Surinam", "SR");
            nameLaender.Add("Sao Tome und Principe", "ST");
            nameLaender.Add("El Salvador", "SV");
            nameLaender.Add("St. Martin(nl.)", "SX");
            nameLaender.Add("Syrien", "SY");
            nameLaender.Add("Swasiland", "SZ");
            nameLaender.Add("Turks- und Caicosinseln", "TC");
            nameLaender.Add("Turks-,Caicosin", "TC");
            nameLaender.Add("Tschad", "TD");
            nameLaender.Add("Französische Süd- und Antarktisgebiete", "TF");
            nameLaender.Add("Togo", "TG");
            nameLaender.Add("Thailand", "TH");
            nameLaender.Add("Tadschikistan", "TJ");
            nameLaender.Add("Tokelau", "TK");
            nameLaender.Add("Tokelau-Inseln", "TK");
            nameLaender.Add("Timor-Leste (Ostimor)", "TL");     // not listed anymore?
            nameLaender.Add("Turkmenistan", "TM");
            nameLaender.Add("Tunesien", "TN");
            nameLaender.Add("Tonga", "TO");
            nameLaender.Add("Ost Timor", "TP");
            nameLaender.Add("Türkei", "TR");
            nameLaender.Add("Trinidad und Tobago", "TT");
            nameLaender.Add("Trinidad,Tobago", "TT");
            nameLaender.Add("Tuvalu", "TV");
            nameLaender.Add("Taiwan", "TW");
            nameLaender.Add("Tansania", "TZ");
            nameLaender.Add("Ukraine", "UA");
            nameLaender.Add("Uganda", "UG");
            nameLaender.Add("Minor Outlying Islands", "UM");
            nameLaender.Add("Vereinigte Staaten von Amerika", "US");
            nameLaender.Add("USA", "US");
            nameLaender.Add("Uruguay", "UY");
            nameLaender.Add("Usbekistan", "UZ");
            nameLaender.Add("Vatikan", "VA");
            nameLaender.Add("Vatikanstadt", "VA");
            nameLaender.Add("St. Vincent und die Grenadinen", "VC");
            nameLaender.Add("St. Vincent", "VC");
            nameLaender.Add("Venezuela", "VE");
            nameLaender.Add("Britische Jungferninseln", "VG");
            nameLaender.Add("Amerikanische Jungferninseln", "VI");
            nameLaender.Add("Vietnam", "VN");
            nameLaender.Add("Vanuatu", "VU");
            nameLaender.Add("Wallis und Futuna", "WF");
            nameLaender.Add("Wallis,Futuna", "WF");
            nameLaender.Add("Samoa", "WS");
            nameLaender.Add("Westsamoa", "WS");
            nameLaender.Add("Kosovo", "XK");
            nameLaender.Add("Jemen", "YE");
            nameLaender.Add("Mayotte", "YT");
            nameLaender.Add("Südafrika", "ZA");
            nameLaender.Add("Sambia", "ZM");
            nameLaender.Add("Simbabwe", "ZW");
        }
    }
}