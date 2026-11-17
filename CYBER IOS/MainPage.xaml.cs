namespace FFGhostCheat
{
    public partial class MainPage : ContentPage
    {
        private bool isEspOn = false;
        private bool isAimOn = false;
        private bool isRageOn = false;
        private int fireSpeed = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        // Lógica da Velocidade (1 a 4)
        private void OnSpeedChange(object sender, ValueChangedEventArgs e)
        {
            fireSpeed = (int)e.NewValue;
            string nivel = "";
            switch (fireSpeed)
            {
                case 1: nivel = "Leve (6 tiros/s)"; break;
                case 2: nivel = "Normal (10 tiros/s)"; break;
                case 3: nivel = "Rápido (15 tiros/s)"; break;
                case 4: nivel = "Hiper (25 tiros/s)"; break;
            }
            lblSpeed.Text = $"Nível: {fireSpeed} - {nivel}";
        }

        // Botão ESP
        private async void BtnEsp_Click(object sender, EventArgs e)
        {
            isEspOn = !isEspOn;
            if (isEspOn)
            {
                lblStatus.Text = "ESP Ativo: Cabeça, Pescoço e Vida Visíveis";
                // Aqui entraria a lógica de desenhar retângulos na tela
            }
            else
            {
                lblStatus.Text = "ESP Desativado";
            }
        }

        // Botão Aimbot
        private async void BtnAim_Click(object sender, EventArgs e)
        {
            isAimOn = !isAimOn;
            if (isAimOn)
            {
                lblStatus.Text = "Aimbot: Foco em Cabeça e Pescoço (HS Alto)";
            }
            else
            {
                lblStatus.Text = "Aimbot Desativado";
            }
        }

        // Botão Modo Rage
        private async void BtnRage_Click(object sender, EventArgs e)
        {
            isRageOn = !isRageOn;
            if (isRageOn)
            {
                lblStatus.Text = "Modo RAGE: Recuo Anulado! 🔥";
            }
            else
            {
                lblStatus.Text = "Modo Normal";
            }
        }

        // Botão Kit
        private async void BtnKit_Click(object sender, EventArgs e)
        {
            await DisplayAlert("Kit", "Kit Ativado: Curativo Automático + Troca Rápida", "OK");
            lblStatus.Text = "Kit Relâmpago Ativo ⚡";
        }

        // Botão Sumir
        private async void BtnHide_Click(object sender, EventArgs e)
        {
            // Esconde toda a interface visual
            this.BackgroundColor = Colors.Transparent;
            foreach (var view in this.Content.Children)
            {
                view.IsVisible = false;
            }
            lblStatus.Text = "Interface Oculta (Toque duplo para voltar)";
        }