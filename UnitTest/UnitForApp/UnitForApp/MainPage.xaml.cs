using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Boş Sayfa öğe şablonu https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x41f adresinde açıklanmaktadır

namespace UnitForApp
{
    /// <summary>
    /// Kendi başına kullanılabilecek ya da bir Çerçeve içine taşınabilecek boş bir sayfa.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Hesapla Hesapla = new Hesapla();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Hesapla_Click(object sender, RoutedEventArgs e)
        {
            decimal kilo = Convert.ToDecimal(textBox_Kilo.Text);
            decimal boy = Convert.ToDecimal(textBox_Boy.Text);
            textBlock_Result.Text = Convert.ToString(Hesapla.hesapla(boy, kilo));
        }
    }
}
