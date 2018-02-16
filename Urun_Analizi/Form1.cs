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
using weka.classifiers.bayes;
using weka.core;
using weka.core.converters;

namespace Urun_Analizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string RefreshTrainSet()
        {
            return "@relation urun\n\n@attribute sicaklik numeric\n@attribute nem numeric\n@attribute yagis numeric\n@attribute deniz {TRUE, FALSE}\n@attribute urun {bugday,arpa,cilek,misir,pirinc,cay,zeytin,fasulye,findik,turuncgil,incir,uzum,muz}\n\n@data";
        }
        string TrainPath;
        public void Classify()
        {
            // Train Dataset yolu
            ConverterUtils.DataSource source1 = new ConverterUtils.DataSource(TrainPath);
            Instances train = source1.getDataSet();
            
            if (train.classIndex() == -1)
                train.setClassIndex(train.numAttributes() - 1);

            //Tahmin edilecek data'nın yolu
            ConverterUtils.DataSource source2 = new ConverterUtils.DataSource(Application.StartupPath+"\\UrunPredict.arff");
            Instances test = source2.getDataSet();
            

            if (test.classIndex() == -1)
                test.setClassIndex(train.numAttributes() - 1);

            
            //Sınıflandırma algoritmasının belirlenmesi
           /* weka.classifiers.lazy.IBk ibk = new weka.classifiers.lazy.IBk();
            //En yakın komşu 'k' değeri 3 olarak belirleniyor
            ibk.setKNN(3);
            ibk.buildClassifier(train);*/
            
            //NAIVE BAYES ALGORITMASI UYGULAMA
             NaiveBayes naiveBayes = new NaiveBayes();
              naiveBayes.buildClassifier(train);

            //Sınıflandırma işlemi uygulanıyor
              double label = naiveBayes.classifyInstance(test.instance(0));
            test.instance(0).setClassValue(label);

            
            //Yeni sınıflandısrılan verinin train veri setine eklenmesi 
            string AddClassifiedData = txtSicaklik.Text + "," + txtNem.Text + "," + txtYagis.Text + "," + cmbDeniz.Text +","+ test.instance(0).stringValue(4);
            StreamWriter Kayit = File.AppendText(TrainPath);
            Kayit.WriteLine("\n"+AddClassifiedData);
            Kayit.Close();

            ShowImageAndInfo(test.instance(0).stringValue(4));
            
        }
        private void btnSetTrain_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arff Dosyası |*.arff";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.ShowDialog();

            TrainPath = openFileDialog1.FileName;
            
            lblSetName.Text = TrainPath;
        }
        public void ShowImageAndInfo(string cl_name)
        {
            if(cl_name=="bugday")
            {
                pictureBox1.Image= Image.FromFile(Application.StartupPath +"\\urun_resimler\\bugday.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Buğday'";
            }
            if (cl_name == "arpa")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\arpa.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Arpa'";
            }
            if (cl_name == "cay")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\cay.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Çaydır'";
            }
            if (cl_name == "cilek")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\cilek.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Çilek'";
            }
            if (cl_name == "fasulye")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\fasulye.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Fasulye'";
            }
            if (cl_name == "findik")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\findik.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Fındık'";
            }
            if (cl_name == "incir")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\incir.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'İncir'";
            }
            if (cl_name == "misir")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\misir.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Mısır'";
            }
            if (cl_name == "muz")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\muz.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Muz'";
            }
            if (cl_name == "pirinc")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\pirinc.gif");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Pirinç'";
            }
            if (cl_name == "turuncgil")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\turuncgil.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Turunçgil'";
            }
            if (cl_name == "uzum")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\uzum.jpg");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Üzüm'";
            }
            if (cl_name == "zeytin")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\urun_resimler\\zeytin.gif");
                lblUrun.Text = "Girilen iklim koşullarınıza uygun \nyetiştirilebilir ürün: 'Zeytin'";
            }
        }
        private void btnClassify_Click(object sender, EventArgs e)
        {
            if (txtNem.Text == "" || txtSicaklik.Text == "" || txtYagis.Text == "" || cmbDeniz.Text == "" || TrainPath == null)
            { MessageBox.Show("Lütfen eksik işlem bırakmayın..!"); }
            else if(float.Parse((txtNem.Text).Replace(".", ",")) > 100 || float.Parse((txtNem.Text).Replace(".", ",")) < 0)
            { MessageBox.Show("Geçerli bir yüzdelik nem oranı girin.."); }

            
            else
            {
                string TestData = txtSicaklik.Text + "," + txtNem.Text + "," + txtYagis.Text + "," + cmbDeniz.Text + ",?";

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Arff Dosyası|*.arff";
                save.OverwritePrompt = true;
                save.CreatePrompt = true;


                StreamWriter Kayit = new StreamWriter(Application.StartupPath+"\\UrunPredict.arff");
                Kayit.WriteLine(RefreshTrainSet() + "\n\n" + TestData);
                Kayit.Close();


                Classify();
            }
        }

        private void txtSicaklik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!='-' && e.KeyChar!='.';
        }

        private void txtNem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtYagis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
