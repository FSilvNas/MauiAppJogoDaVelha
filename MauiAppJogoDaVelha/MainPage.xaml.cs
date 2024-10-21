namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int cont_jogadas = 0;
        int velha = 0;
        int vitoria_x = 0;
        int vitoria_o = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Encerrar_Jogo_Click(object sender, EventArgs e)
        {

            DisplayAlert("Fim de Jogo", $"Jogador X: {vitoria_x}.\nJogador O: {vitoria_o}.\nVelha: {velha}", "Voltar ao jogo");
            Zerar();
            vitoria_o=0;
            vitoria_x=0;
            velha = 0;
            cont_jogadas = 0;
        }

        private void ButtonExibirResultados_Click(object sender, EventArgs e)
        {
            DisplayAlert("Placar", $"Jogador X: {vitoria_x}.\nJogador O: {vitoria_o}.\nVelha: {velha}", "Voltar ao jogo");
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            cont_jogadas++;


            // Verificando se deu velha
            if (cont_jogadas >= 9)
            {
                DisplayAlert("Ops", "Deu Velha!", "OK");
                velha++;
                Zerar();
            }



            // Verificando as linhas
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns", "Vitória do X!", "Novo Jogo");
                vitoria_x++;
                Zerar();
            }
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns", "Vitória do X!", "Novo Jogo");
                vitoria_x++;
                Zerar();
            }

            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "Vitória do X!", "Novo Jogo");
                vitoria_x++;
                Zerar();
            }

            // Verificando as colunas
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "Vitória do X!", "Novo Jogo");
                vitoria_x++;
                Zerar();
            }
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns", "Vitória do X!", "Novo Jogo");
                vitoria_x++;
                Zerar();
            }
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "Vitória do X!", "Novo Jogo");
                vitoria_x++;
                Zerar();
            }

            // Verificando as diagonais
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "Vitória do X!", "Novo Jogo");
                vitoria_x++;
                Zerar();
            }
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "Vitória do X!", "Novo Jogo");
                vitoria_x++;
                Zerar();
            }

            // Verificando as linhas para "O"
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "Vitória do O!", "Novo Jogo");
                vitoria_o++;
                Zerar();
            }
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns", "Vitória do O!", "Novo Jogo");
                vitoria_o++;
                Zerar();
            }
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "Vitória do O!", "Novo Jogo");
                vitoria_o++;
                Zerar();
            }

            // Verificando as colunas para "O"
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "Vitória do O!", "Novo Jogo");
                vitoria_o++;
                Zerar();
            }
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns", "Vitória do O!", "Novo Jogo");
                vitoria_o++;
                Zerar();
            }
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "Vitória do O!", "Novo Jogo");
                vitoria_o++;
                Zerar();
            }

            // Verificando as diagonais para "O"
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "Vitória do O!", "Novo Jogo");
                vitoria_o++;
                Zerar();
            }
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "Vitória do O!", "Novo Jogo");
                vitoria_o++;
                Zerar();
            }



        }
        private void Zerar()
        {

            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            // Resetar contador de jogadas e vez
            cont_jogadas = 0;
            vez = "X";
        }
    }
}
