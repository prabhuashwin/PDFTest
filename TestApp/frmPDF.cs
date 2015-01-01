using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Tls;

namespace TestApp
{
    public partial class frmMain : Form
    {

        private double fileSize = 0;
        private int numberOfPages = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            filedlgOpenPDFfile.ShowDialog();
            //filedlgOpenPDFfile.Filter = "PDF files";

            if (filedlgOpenPDFfile.FileName == "" || !filedlgOpenPDFfile.FileName.Contains(".pdf"))
            {
                MessageBox.Show("Select PDF file only", "PDF Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtpdfFileInput.Text = filedlgOpenPDFfile.FileName;

            
        }

        public static void ExtractPages(string sourcePdfPath, string outputPdfPath,
    int startPage, int endPage)
        {
            PdfReader reader = null;
            Document sourceDocument = null;
            PdfCopy pdfCopyProvider = null;
            PdfImportedPage importedPage = null;

            try
            {
                // Intialize a new PdfReader instance with the contents of the source Pdf file:
                reader = new PdfReader(sourcePdfPath);

                // For simplicity, I am assuming all the pages share the same size
                // and rotation as the first page:
                sourceDocument = new Document(reader.GetPageSizeWithRotation(startPage));

                // Initialize an instance of the PdfCopyClass with the source 
                // document and an output file stream:
                pdfCopyProvider = new PdfCopy(sourceDocument,
                    new System.IO.FileStream(outputPdfPath, System.IO.FileMode.Create));

                sourceDocument.Open();

                // Walk the specified range and add the page copies to the output file:
                for (int i = startPage; i <= endPage; i++)
                {
                    importedPage = pdfCopyProvider.GetImportedPage(reader, i);
                    pdfCopyProvider.AddPage(importedPage);
                }
                sourceDocument.Close();
                reader.Close();
            }
            catch (DirectoryNotFoundException dirEx)
            {
                // Let the user know that the directory did not exist.
                Console.WriteLine("Directory not found: " + dirEx.Message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            int fileSizegiven = Convert.ToInt16(txtFileSize.Text);

            int pageInfo = numberOfPages/fileSizegiven;

            string fileName = Path.GetFileNameWithoutExtension(txtpdfFileInput.Text);

            int strtPage = 1;
            int endPage = pageInfo;

            for (int i = 0; endPage < numberOfPages; i++)
            {
                ExtractPages(txtpdfFileInput.Text, txtpdffileOutput.Text + "\\" + fileName + i + ".pdf", strtPage, endPage);

                strtPage = endPage + 1;
                endPage += pageInfo;
            }
            MessageBox.Show("PDF files have been created", "PDF Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            folderBrowdiagPdf.ShowDialog();

            txtpdffileOutput.Text = folderBrowdiagPdf.SelectedPath;

            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = new FileInfo(txtpdfFileInput.Text).Length;
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            //Get the size of the file
            var result = len;

            //Round off the size
            var roundNum = Math.Round(result, 0);

            //divide the file into parts based on size
            var fileSize = Math.Round(roundNum / 2, 0);

            lblSizeText.Visible = true;
            lblFileSize.Visible = true;
            txtFileSize.Visible = true;
            lblSizeTextName.Visible = true;
            btnSplit.Visible = true;

            lblFileSize.Text = fileSize.ToString() + " MB";

            PdfReader pdfReader = new PdfReader(txtpdfFileInput.Text);
            numberOfPages = pdfReader.NumberOfPages;
        }
    }
}
