using Avalonia.Controls;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace HW03avalonia;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

       BtnSoubor.Click += async (_, _) =>//lambda funkce pro kliknuti na tlacitko
       {
           var dialog = new OpenFileDialog();//otevření okna pro vybrání souboru
           dialog.Filters.Add(new FileDialogFilter() { Name = "Textové soubory", Extensions = { "txt" } });//vyfiltrování textových souborů

           var result = await dialog.ShowAsync(this);//ukládá cestu k souborům

           if (result != null && result.Length > 0)//kontrola vybrání souboru
           {
               string cesta = result[0];//cesta k souboru
               string obsah = await File.ReadAllTextAsync(cesta);//načte obsah souboru a uloží ho do obsah

               int pocet = obsah
                   .Split(' ', '\n', '\r', '\t', '.', ',', '!', '?') //rozdělení textu na jednotlivá slova
                   .Count(s => !string.IsNullOrWhiteSpace(s));//počítá neprázdné části

               await ShowMessage($"Počet slov v souboru: {pocet}");//zobrazuje výsledek
           }
       };
    }
    private async Task ShowMessage(string zprava)//funkce na zobrazeni vysledku
    {
        var okno = new Window//vytvari nové okno
        {
            Width = 250,
            Height = 100,
            Title = "Výsledek",
            Content = new TextBlock
            {
                Text = zprava,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center
            }
        };

        await okno.ShowDialog(this);//zobrazi nove okno nad tím hlavním
    }
}