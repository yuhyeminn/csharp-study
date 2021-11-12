using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Study_17_XMLReader_XMLWriter
{
    public partial class Form1 : Form
    {
        CXMLControl _XML = new CXMLControl();
        Dictionary<string, string> _dData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfigSet_Click(object sender, EventArgs e)
        {
            string strEnter = "\r\n";
            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + strEnter)
                .Append(bChecked.ToString() + strEnter)
                .Append(iNumber.ToString() + strEnter);

            tboxConfigData.Text = sb.ToString();

            //////////// Dictionary에 Config 저장
            _dData.Clear();

            _dData.Add(CXMLControl._TEXT_DATA, strText);
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;
            SFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;

                _XML.fXML_Writer(strFilePath, _dData);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;
            OFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            OFDialog.FileName = "*.xml";
            OFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            StringBuilder sb = new StringBuilder();

            if(OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                sb.Append(File.ReadAllText(strFilePath));

                // 화면에 출력
                tboxConfigData.Text = sb.ToString();

                _dData.Clear();
                _dData = _XML.fXML_Reader(strFilePath);
            }
        }

        private void btnConfigRead_Click(object sender, EventArgs e)
        {
            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);
        }
    }
}
