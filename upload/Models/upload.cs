using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


namespace upload
{
public partial class upload : System.Web
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private bool UploadArquivo()
    {

        FileUpload1.SaveAs((@"img\"
                + FileUpload1.FileName));
        return true;
    }

    private void Ler()
    {
        List<string> lista = new List<string>();

        using (StreamReader sr = new StreamReader(@"img\"
        + FileUpload1.FileName))
        {
            string linha = sr.ReadToEnd();
            string[] array = linha.Split(';');

            txtData.Text = array[0];
        	  txtIdade.Text = array[1];
            txtValor.Text = array[2];


        }

    }
    protected void button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.PostedFile.ContentType == "text/plain")
        {
            try
            {
                if (UploadArquivo())
                {

                    Ler();


                }
                else
                {
                //    Statuslbl.Text = "Não foi possível realizar a
                  //  importação do arquivo";
                }
            }

            catch (Exception)
            {

                throw;
            }
        }
        else
        {
            Statuslbl.Text = "Favor coloque um arquivo .txt";

        }
    }

}
}