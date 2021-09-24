using Project_.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // private void button1_Click(object sender, EventArgs e)
      //  {

            // var client= new HttpClient(); // client nesnesi oluşturma 
            // client.BaseAddress = new Uri("http://localhost:8091/"); //BaseAdress verme 
            // HttpResponseMessage response = await client.GetAsync("api/sehir");  //RESPONSE bağlanmak istenilen adres verilmesi .HAngi URL den data almak isteniyorsa o döndürülür
            // string result = await response.Content.ReadAsStringAsync(); // API'den gelen cevap 
            // label1.Text = result; // Label'a sonuç yazdırmak 'Json olarak gelir' 

            //private async void Delete_Click(object sender, EventArgs e)
          //private async void Delete_Click(object sender, EventArgs e)
             //    var responce = await RestHelper.Delete(txtID.Text);
             //    txtResponse.Text = responce;
             //
             //
        //}


        private async void button5_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Get(txtID.Text); // txtID nin içindeki değer okunabilmesi için 
            txtResponse.Text = RestHelper.BeautifyJson(responce);
        }

        private async void GetAll_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.GetALL(); // GetALl çalışması için 
            txtResponse.Text = RestHelper.BeautifyJson(responce); // json olarak cevap gelir 


        }

        private async void Post_Click(object sender, EventArgs e) // asekron olarak çalışmasını istediğimizde "async" 
        {
            var responce = await RestHelper.Post(txtName.Text, txtjob.Text);  // post etmek istenilen labellar parametre olarak yazılır.
            txtResponse.Text = RestHelper.BeautifyJson(responce);
        }

        private async void Put_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Put(txtID.Text, txtName.Text, txtjob.Text); // Not: await-->async 
            txtResponse.Text = RestHelper.BeautifyJson(responce);
        }

      // private async void Delete_Click(object sender, EventArgs e)
      // {
      //     var responce = await RestHelper.Delete(txtID.Text); // Not: await-->async 
      //     txtResponse.Text = RestHelper.BeautifyJson(responce);
      //
      // }
        //private static async Task<string> Delete(string id) // belirli bir id çekmek için 
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        using (HttpResponseMessage res = await client.DeleteAsync("https://reqres.in/api/users/2"+ id))
        //        {
        //            using (HttpContent content = res.Content)
        //            {
        //                MessageBox.Show(res.StatusCode.ToString());
        //                string data = await content.ReadAsStringAsync();
        //                if (data != null)
        //                {
        //                    return data;
        //                }
        //
        //            }
        //        }
        //    }
        //    return string.Empty;
        //
        //}


    }
}


 

