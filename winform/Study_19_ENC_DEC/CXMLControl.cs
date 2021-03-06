using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Study_19_ENC_DEC
{
    class CXMLControl
    {
        public static string _TICK = "TICK";
        public static string _TOTAL = "TOTAL";
        public static string _LEVEL_1 = "LEVEL_1";
        public static string _LEVEL_3 = "LEVEL_3";
        public static string _LEVEL_50 = "LEVEL_50";

        public void fXML_Writer(string strXMLPath, Dictionary<string, string> DXMLConfig)
        {
            StringBuilder sb = new StringBuilder();

            using (XmlWriter wr = XmlWriter.Create(sb))
            {
                wr.WriteStartDocument();

                // SETTING
                wr.WriteStartElement("SETTING");
                wr.WriteAttributeString("ID", "0001");

                wr.WriteElementString(_TICK, DXMLConfig[_TICK]);
                wr.WriteElementString(_TOTAL, DXMLConfig[_TOTAL]);
                wr.WriteElementString(_LEVEL_1, DXMLConfig[_LEVEL_1]);
                wr.WriteElementString(_LEVEL_3, DXMLConfig[_LEVEL_3]);
                wr.WriteElementString(_LEVEL_50, DXMLConfig[_LEVEL_50]);

                wr.WriteEndElement();
                wr.WriteEndDocument();
            }

            string strRijndaelText = CRijndael.EncryptString(sb.ToString(), CRijndael._bkey);

            File.WriteAllText(strXMLPath, strRijndaelText);
        }

        public Dictionary<string, string> fXML_Reader(string strXMLPath)
        {
            string strRijndaelText = File.ReadAllText(strXMLPath);
            string strDECText = CRijndael.DecryptString(strRijndaelText, CRijndael._bkey);


            Dictionary<string, string> DXMLConfig = new Dictionary<string, string>();

            // using 범위 내에 XmlWriter를 정의 하여 using을 벗어 나게 될 경우 자동으로 Dispose 하여 메모리를 관리
            using (XmlReader rd = XmlReader.Create(new StringReader(strDECText)))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name.Equals("SETTING"))
                        {
                            string strID = rd["ID"];
                            rd.Read();

                            string strTICK = rd.ReadElementContentAsString(_TICK, "");
                            DXMLConfig.Add(_TICK, strTICK);

                            string strTOTAL = rd.ReadElementContentAsString(_TOTAL, "");
                            DXMLConfig.Add(_TOTAL, strTOTAL);

                            string strLEVEL1 = rd.ReadElementContentAsString(_LEVEL_1, "");
                            DXMLConfig.Add(_LEVEL_1, strLEVEL1);

                            string strLEVEL3 = rd.ReadElementContentAsString(_LEVEL_3, "");
                            DXMLConfig.Add(_LEVEL_3, strLEVEL1);

                            string strLEVEL50 = rd.ReadElementContentAsString(_LEVEL_50, "");
                            DXMLConfig.Add(_LEVEL_50, strLEVEL1);
                        }
                    }
                }
            }
            return DXMLConfig;
        }
    }
}
