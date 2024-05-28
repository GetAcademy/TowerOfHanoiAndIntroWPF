using System.Windows;
using System.Windows.Controls;

namespace WpfIntro
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();

            var panel = new StackPanel();
            //var clickerPanel1 = new ClickerPanel();
            //var clickerPanel2 = new ClickerPanel();
            //var clickerPanel3 = new ClickerPanel();
            //panel.Children.Add(clickerPanel1);
            //panel.Children.Add(clickerPanel2);
            //panel.Children.Add(clickerPanel3);
            var clicker1 = new Clicker();
            var clicker2 = new Clicker();
            var clicker3 = new Clicker();

            panel.Children.Add(clicker1.Panel);
            panel.Children.Add(clicker2.Panel);
            panel.Children.Add(clicker3.Panel);

            window.Content = panel;
            app.Run(window);
        }
    }
}
