using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace rocnikova.prace
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _dialogText;
        private string spravnyKod = "8361";
        private string spravnyKod2 = "6299";
        private int pokusy = 3;
        private bool maKlicOdBrany = false;
        public string DialogText
        {
            get => _dialogText;
            set
            {
                _dialogText = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            DialogText = "Cíl: \nNajdi klíč a uteč do další místnosti.";

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void btn_pacidlo_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "To by se mohlo hodit na útěk odsud.";
        }

        private void btn_kamen_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Hmm Kámen ten bych mohl potřeboval rozbít okno.";
        }

        private void btn_klic_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Našel jsi klíč!";
            Prejdi_Do_Sceny2();
        }

        private void btn_brusle_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Brusle nepoužiju, tu tady nechám.";
        }

        private void btn_sroubovak_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Šroubovák se může hodit.";
        }

        private void btn_hrnek_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Hrnečky mám doma...";
        }
        private void Koncis()
        {
            Scena1.Visibility = Visibility.Collapsed;
            Menu.Visibility = Visibility.Visible;
        }
        private void btn_obraz_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Byl jsi prokletý. Tady končíš...";
            Koncis();
        }

        private void btn_parek_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Párek? co to tu dělá?";
        }
        private void Prejdi_Do_Sceny2()
        {
            Scena1.Visibility = Visibility.Collapsed;
            Scena2.Visibility = Visibility.Visible;
            DialogText = "Cíl: \nNajdi 4 čísla kódu a zadej ho do počítače a uteč do další místnosti.";

        }

        private void btn_cislo1_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Toto je první číslo kódu\n ZAPAMATUJ SI HO!!!";
        }

        private void btn_cislo2_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Toto je druhé číslo kódu\n ZAPAMATUJ SI HO!!!";
        }

        private void btn_cislo3_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Toto je třetí číslo kódu \n ZAPAMATUJ SI HO!!!";
        }

        private void btn_cislo4_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Toto je čtvrté číslo kódu \n ZAPAMATUJ SI HO!!!";
        }
        private void btn_click_heslo(object sender, RoutedEventArgs e)
        {
            zadej_Heslo();
        }
        private void zadej_Heslo()
        {
            Scena2.Visibility = Visibility.Collapsed;
            Kod.Visibility = Visibility.Visible;
            DialogText = "Cíl: \nZadej heslo do počítače.";
        }

        private void btn_kontrola_hesla_Click(object sender, RoutedEventArgs e)
        {
            if (txtKod.Text == spravnyKod)
            {
                DialogText = "Správný kód!";
                Lasery_presun();
            }
            else
            {
                pokusy--;
                txtKod.Clear();

                if (pokusy > 0)
                {
                    DialogText = $"Špatný kód! Zbývá pokusů: {pokusy}";
                }
                else
                {
                    DialogText = "GAME OVER";
                    Kod.Visibility = Visibility.Collapsed;
                    Koncis();
                }
            }
        }
        private void Lasery_presun()
        {
            Kod.Visibility = Visibility.Collapsed;
            Lasery.Visibility = Visibility.Visible;
            DialogText = "Cíl: \nZjisti heslo, dostaň se ke kódovníku a uteč odsud.";

        }

        private void btn_zpet_Click(object sender, RoutedEventArgs e)
        {
            Navrat_do_sec_room();
        }
        private void Navrat_do_sec_room()
        {
            Kod.Visibility = Visibility.Collapsed;
            Scena2.Visibility = Visibility.Visible;

        }

        private void btn_kniha_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "V knize jsem našel číslo jsem našel nějaké moudra";
        }

        private void btn_sprej_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Tady má někdo rád grafity";
        }

        private void btn_baterka_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Na baterce nic není";
        }

        private void btn_klic2_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "To už je třeba 4 klíč co jsem našel a je na něm číslo 6";
        }

        private void btn_krabice_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "V krabici je 7 hraček a našel jsem číslo 2";
        }

        private void btn_suplik_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Tady v tom šuplíku jsou jenom hnusné staré odpadky.";
        }

        private void btn_televize_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Tahle televize snad zažila i 2. Světovou válku a je na ní číslo 9";
        }

        private void btn_ciselnik_Click(object sender, RoutedEventArgs e)
        {
            Ciselnik();
        }

        private void btn_krabice2_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "To už je třeba 3 krabice a je v ní číslo 9";
        }
        private void btn_navod_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "Soustřeď se na to co se ti píše v dialogu a na čísla a jejich pořadí.";
        }
        private void Ciselnik()
        {
            Lasery.Visibility = Visibility.Collapsed;
            Kodovnik.Visibility = Visibility.Visible;
            DialogText = "Cíl: \nZadej Kód.";
        }

        private void btn_notes_Click(object sender, RoutedEventArgs e)
        {
            DialogText = "V notesu jsem našel jenom skvrnu od pera";
        }

        private void Správně(object sender, RoutedEventArgs e)
        {
            if (txtKod2.Text == spravnyKod2)
            {
                DialogText = "Správný kód!";
                Prejdi_na_Konec();
            }
            else
            {
                pokusy--;
                txtKod.Clear();

                if (pokusy > 0)
                {
                    DialogText = $"Špatný kód! Zbývá pokusů: {pokusy}";
                }
                else
                {
                    DialogText = "GAME OVER";
                    Kod.Visibility = Visibility.Collapsed;
                    Koncis();
                }
            }
        }
        private void Zpatky_Lasery()
        {
            Kodovnik.Visibility = Visibility.Collapsed;
            Lasery.Visibility = Visibility.Visible;
        }

        private void Zpatky_Click(object sender, RoutedEventArgs e)
        {
            Zpatky_Lasery();
        }
        private void Prejdi_na_Konec()
        {
            Kodovnik.Visibility = Visibility.Collapsed;
            Konec.Visibility = Visibility.Visible;
            DialogText = "Cíl:\nNajdi klíč a uteč.";

        }
        private void Prejdi_do_hry()
        {
            Scena1.Visibility = Visibility.Visible;
            Menu.Visibility = Visibility.Collapsed; 
        }
        private void start(object sender, RoutedEventArgs e)
        {
            Prejdi_do_hry();
        }

        private void konec(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void klic_brana(object sender, RoutedEventArgs e)
        {
            maKlicOdBrany = true;
            DialogText = "Mám klíč teď ho už jen utéct.";
        }

        private void brana(object sender, RoutedEventArgs e)
        {
            if (maKlicOdBrany)
            {
                DialogText = "Dostal ses z paláce zla\nVYHRÁL JSI";
            }
            else
            {
                DialogText = "Brána je zamčená. Nejdřív najdi klíč.";
            }
        }
    }
}