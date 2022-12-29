using BL.Models.Interfaces;
using JuegoDevInMotion.Models;

namespace JuegoDevInMotion
{
    public partial class Form1 : Form
    {
        IPesonaje _personaje;
        IArmasService _armasService;
        IContexturaService _contexturaService;
        IControladorEstamina _controladorEstamina;
        public Form1(IPesonaje personaje, IArmasService armasService, IContexturaService contexturaService, IControladorEstamina controladorEstamina)
        {
            InitializeComponent();
            _personaje = personaje;
            _armasService = armasService;
            _contexturaService = contexturaService;
            _controladorEstamina = controladorEstamina;
            CargarArmas();
            CargarContexturas();
            _controladorEstamina.RegistrarOberserver(_personaje.GetAtaque());
            _controladorEstamina.RegistrarOberserver(_personaje.GetSaltar());
            _controladorEstamina.RegistrarOberserver(_personaje.GetCorrer());
            _controladorEstamina.NotificarObservers();
            SetEstamina();
        }

        private void CargarArmas()
        {
            var armas = _armasService.GetArmas();
            this.armas.Items.Add(new ComboBoxItem()
            {
                Value = 0,
                Text = "Seleccione una Arma"
            });
            this.armas.SelectedIndex = 0;

            foreach(var arma in armas)
            {
                this.armas.Items.Add(new ComboBoxItem()
                {
                    Text = arma.Nombre,
                    Value = arma.Id
                });
            }
        }

        private void CargarContexturas()
        {
            var contexturas = _contexturaService.GetContexturas();
            this.contexturas.Items.Add(new ComboBoxItem() { 
                Value = 0,
                Text = "Seleccione una contextura"
            });

            this.contexturas.SelectedIndex = 0;
            foreach (var contextura in contexturas)
            {
                this.contexturas.Items.Add(new ComboBoxItem()
                {
                    Text = contextura.Nombre,
                    Value = contextura.Id
                });
            }
        }

        protected void CotexturaOnChanged(object sender, System.EventArgs e)
        {
            int id = GetComboBoxValue(sender);
            if ( id == 0 )
            {
                return;
            }

            Console.WriteLine(id);
            var contextura = _contexturaService.GetContexturaById(id);
            _personaje.SetContextura(contextura);
        }

        protected void ArmasOnChanged(object sender, System.EventArgs e)
        {            
            int id = GetComboBoxValue(sender);
            if (id == 0)
            {
                return;
            }

            var arma = _armasService.GetArmaById(id);
            _personaje.SetArma(arma);
        }

        private int GetComboBoxValue(object sender)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem item = (ComboBoxItem)comboBox.SelectedItem;
            return int.Parse(item.Value.ToString());
        }

        public void OnAtacar(object sender, EventArgs e)
        {
            double[]? ataque = _personaje.Ataque();
            if ( ataque == null )
            {
                this.accionesText.Text = "Acción no realizada";
                return;
            }

            double daño = ataque[0];
            double cantidad = ataque[1];
            double reduccionEstamina = ataque[2];
            _controladorEstamina.ReduccionEstamina(reduccionEstamina);
            this.accionesText.Text = $"Atacar Daño Por golpe: { daño } Golpes: { cantidad }";
            SetEstamina();
        }

        public void OnSaltar(object sender, EventArgs e)
        {
            double[]? salto = _personaje.Salto();
            if (salto == null)
            {
                this.accionesText.Text = "Acción no realizada";
                return;
            }

            double altura = salto[0];
            double reduccionEstamina = salto[1];
            _controladorEstamina.ReduccionEstamina(reduccionEstamina);
            this.accionesText.Text = $"Saltar Altura: { altura } mts";
            SetEstamina();
        }

        public void OnCorrer(object sender, EventArgs e)
        {
            double[]? correr = _personaje.Correr();
            if ( correr == null )
            {
                this.accionesText.Text = "Acción no realizada";
                return;
            }

            double velocidad = correr[0];
            double reduccionEstamina = correr[1];
            _controladorEstamina.ReduccionEstamina(reduccionEstamina);
            this.accionesText.Text = $"Correr Velocidad: { velocidad } metros/segundo";
            SetEstamina();
        }

        private void SetEstamina()
        {
            this.estamina.Text = $"Estamina: { _controladorEstamina.GetEstamina() }";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}