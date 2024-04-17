using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO
{
    public class Gestor
    {
        //variavel
        private List<Passageiro> pessoaList;
        private List<Rota> LR; 
        private Dictionary<string, List<Voo>> voosPorDestino;
        private List<string> BilheteEfe;
        private List<string> Bilhetesuplente;

        //construtor
        public Gestor()
        {
            pessoaList = new List<Passageiro>();
            LR = new List<Rota>();
            voosPorDestino = new Dictionary<string, List<Voo>>();
            BilheteEfe = new List<string>();
            Bilhetesuplente = new List<string>();
        }
        //metodos

        //Adicionar Passageiro
        public string AdicionaPassageiro(string nome, string morada, DateTime dataNasc, int nif)
        {
            foreach (Passageiro t in pessoaList)
                if (t.getNif() == nif)
                    return "Passageiro já existente!";

            Passageiro pass = new(nome, morada, dataNasc, nif);
            pessoaList.Add(pass);
            return "Passageiro inserido com sucesso!";
        }
        //gravarficheiro Passageiro
        public void gravarpassageirosficheiro(string nomeF)
        {
            StreamWriter? F = null;

            try
            {
                F = new StreamWriter(nomeF);
                foreach (Passageiro p in pessoaList)
                {
                    F.WriteLine(p.getNome() + ';' + p.GetMorada() + ';' + p.GetDataNas().ToString("dd/MM/yyyy") + ';' + p.getNif());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de I/O " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de execução " + e);
            }
            finally
            {
                if (F != null)
                {
                    Console.WriteLine("Ficheiro Passageiros gravado com sucesso!");
                    F.Close();
                }
            }
        }
        //lerficheiroPass
        public void LerFicheiroPassageiros(string NomeF)
        {
            StreamReader F = null;
            string linha;
            try
            {
                F = new StreamReader(NomeF);
                
                while ((linha = F.ReadLine()) != null)
                {
                    string[] partes = linha.Split(';');
                    string nome = partes[0];
                    Console.WriteLine(nome);
                    string morada = partes[1];
                    DateTime dataNascimento = DateTime.ParseExact(partes[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine(dataNascimento);
                    int nif = Convert.ToInt32(partes[3]);
                    Passageiro p = new Passageiro(nome, morada, dataNascimento, nif);
                    pessoaList.Add(p);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ficheiro não encontrado!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de I/O " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de execução " + e);
            }
            finally
            {
                if (F != null)
                {
                    Console.WriteLine("Ficheiro Pessoas lido com sucesso!");
                    F.Close();
                }
            }
        }


        //metodo Ler ficheiro rotas
        public void lerrotas(string nomeF) 
        {
            StreamReader RL = null;
            string linha, destino;
            double distancia;
            try
            {
                RL = new StreamReader(nomeF);
                string cabecalho = RL.ReadLine();
                while ((linha = RL.ReadLine()) != null)
                {
                    string[] partes = linha.Split(";");

                    int id_rota = Convert.ToInt32(partes[0]);
                    int n_voos = Convert.ToInt32(partes[1]);
                    destino = partes[2];
                    distancia = Convert.ToDouble(partes[3]);

                    Rota r = new Rota(id_rota, n_voos, destino, distancia);
                    LR.Add(r);

                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ficheiro não encontrado!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de I/O " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de execução " + e);
            }
            finally
            {
                if (RL != null)
                {
                    Console.WriteLine("Ficheiro lido com sucesso!");
                    RL.Close();
                }

            }

            




        }


        //metodo listar passageiros
        public List<Passageiro> getListaPassag()
        {
            return pessoaList;
        }

        //metodo listar a lista de rotas
        public List<Rota> listar_rota()
        {
            return LR;
        }

        //metodo ler ficheiro de voos
        public void LerFicheiroVoos(string caminhoFicheiro)
        {
            try
            {
                using (StreamReader sr = new StreamReader(caminhoFicheiro))
                {
                    string linha;
                    string destinoAtual = null;

                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Verifica se a linha não está vazia
                        if (!string.IsNullOrWhiteSpace(linha))
                        {
                            // Verifica se a linha começa com "ID:"
                            if (linha.StartsWith("Nº VOO:"))
                            {
                                string[] dados = linha.Split(',');

                                if (dados.Length == 6)
                                {
                                    int id_voo = int.Parse(dados[0].Split(':')[1].Trim());
                                    DateTime data = DateTime.ParseExact(dados[1].Split(':')[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                    string hora = dados[2].Split(':')[1].Trim() + ":" +dados[2].Split(':')[2].Trim();
                                    string aviao = dados[4].Split(':')[1].Trim();
                                    int n_lugares = int.Parse(dados[5].Split(':')[1].Trim());

                                    // Adiciona o voo à lista de voos do destino
                                    if (!voosPorDestino.ContainsKey(destinoAtual))
                                    {
                                        voosPorDestino[destinoAtual] = new List<Voo>();
                                    }

                                    // Adiciona o voo à lista
                                    Voo voo = new Voo(id_voo, data, hora, aviao, n_lugares);
                                    voosPorDestino[destinoAtual].Add(voo);
                                }
                                else
                                {
                                    Console.WriteLine($"Ignorando linha com dados inválidos: {linha}");
                                }
                            }
                            // Se não, é o nome do destino
                            else
                            {
                                destinoAtual = linha.Trim();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o ficheiro: {e.Message}");
            }
        }

        //guardar ficheiro voos
        public void GuardarFicheiroVoos(string caminhoFicheiroSaida)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoFicheiroSaida))
                {
                    foreach (var destino in voosPorDestino)
                    {
                        sw.WriteLine(destino.Key); // Escreve o nome do destino

                        foreach (var voo in destino.Value)
                        {
                            // Escreve os dados do voo no arquivo
                            sw.WriteLine($"Nº VOO:{voo.GetIDvoo()}, DATA:{voo.Getdata().ToString("dd/MM/yyyy")}, HORA:{voo.Gethora()}, AVIAO:{voo.Getaviao()}, N_LUGARES:{voo.GetNlugares()}");
                        }

                        sw.WriteLine(); // Adiciona uma linha em branco entre os destinos
                    }
                }

                Console.WriteLine("Ficheiro guardado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro ao guardar o ficheiro: {e.Message}");
            }
        }

        //adicionar rota 
        public string adicionarota(int id_rota, int n_voos, string destino, double distancia)
        {
            foreach (Rota rota in LR)
                if (rota.Getid_rota() == id_rota)
                    return "Rota já existente!";

            Rota rote = new Rota(id_rota, n_voos, destino, distancia);
            LR.Add(rote);
            return "Rota inserida com sucesso!";
        }


        //metodo gravar ficheiro das rotas
        public void Gravarrotas(string nomeF)
        {
            StreamWriter F = null;

            try
            {
                F = new StreamWriter(nomeF);
                foreach (Rota rota in LR)
                    F.WriteLine(rota.Getid_rota() + ";" + rota.Getn_rota()+ ";" + rota.GetDestino() + ";" + rota.Getdistancia());
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de I/O " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de execução " + e);
            }
            finally
            {
                if (F != null)
                {
                    Console.WriteLine("Ficheiro rotas gravado com sucesso!");
                    F.Close();
                }
            }
        }



        //metodo para listar o dicionário. 
        public Dictionary<string, List<Voo>> ListarVoos()
        {
            return voosPorDestino;
        }


        // Atualizar método AdicionarVoo
        public string AdicionarVoo(int id_voo, DateTime data, string hora, string aviao, int n_lugares, string destino)
        {
            if (ListarVoos().ContainsKey(destino))
            {
                foreach (Voo vooExistente in ListarVoos()[destino])
                {
                    if (vooExistente.GetIDvoo() == id_voo)
                    {
                        return "Voo com o mesmo número já existe!";
                    }
                }
            }

            // Verifica se já existe um voo na mesma hora
            if (ListarVoos().ContainsKey(destino))
            {
                foreach (Voo vooExistente in ListarVoos()[destino])
                {
                    if (vooExistente.Gethora() == hora)
                    {
                        return "Já existe um voo marcado para esta hora.";
                    }
                }
            }

            // Verifica se o limite de voos por semana é excedido
            if (ExcedeLimiteVoosSemana(data, destino))
            {
                return "Limite de 7 voos por semana excedido.";
            }

            // Adiciona o voo se todas as verificações passarem
            Voo voar = new Voo(id_voo, data, hora, aviao, n_lugares);

            if (!voosPorDestino.ContainsKey(destino))
            {
                voosPorDestino[destino] = new List<Voo>();
            }

            voosPorDestino[destino].Add(voar);

            // Atualiza o número de voos da rota
            foreach (Rota rota in listar_rota())
            {
                if (rota.GetDestino() == destino)
                {
                    rota.Setn_rota(rota.Getn_rota() + 1);
                    break;  // Se encontrou a rota, pode interromper o loop
                }
            }

            return "Voo inserido com sucesso!";
        }

        // Atualizar método ExcedeLimiteVoosSemana
        public bool ExcedeLimiteVoosSemana(DateTime dataVoo, string destino)
        {
            // Define a data de início da semana como o primeiro dia da semana
            DateTime inicioSemana = dataVoo.Date;
            while (inicioSemana.DayOfWeek != DayOfWeek.Sunday)
            {
                inicioSemana = inicioSemana.AddDays(-1);
            }

            // Define a data de término da semana como o último dia da semana
            DateTime fimSemana = inicioSemana.AddDays(6);

            // Conta quantos voos ocorreram dentro dessa semana para o destino específico
            if (voosPorDestino.ContainsKey(destino))
            {
                int voosSemana = 0;

                foreach (Voo voo in voosPorDestino[destino])
                {
                    if (voo.Getdata() >= inicioSemana && voo.Getdata() <= fimSemana)
                    {
                        voosSemana++;
                    }
                }

                // Retorna true se exceder o limite de 7 voos por semana
                return voosSemana >= 7;
            }

            // Retorna false se não houver voos para o destino na semana
            return false;
        }

        public double CalcularPreco(string destino, double distancia, Bilhete bilhete)
        {
            double preco = bilhete.CalcularPreco(distancia);

            // Retornar o preço calculado
            return preco;
        }


        public double ObterDistanciaParaDestino(string destino)
        {
            foreach (Rota rota in LR)
            {
                if (rota.GetDestino() == destino)
                {
                    return rota.Getdistancia();
                }
            }

            // Retornar um valor padrão caso não encontre a distância
            return 0.0; // Substitua pelo valor padrão desejado
        }

        public string ObterDestinoPorID(int idVoo)
        {
            foreach (var destino in voosPorDestino)
            {
                foreach (var voo in destino.Value)
                {
                    if (voo.GetIDvoo() == idVoo)
                    {
                        return destino.Key;
                    }
                }
            }

            return "Destino não encontrado";
        }


        public string ComprarBilhete(int id_voo, string nif)
        {
            foreach (var destino in voosPorDestino.Values)
            {
                foreach (var voo in destino)
                {
                    if (voo.GetIDvoo() == id_voo)
                    {
                        // Chama o método ComprarBilhete da classe Voo
                        return voo.ComprarBilhete(nif, BilheteEfe, Bilhetesuplente);
                    }
                }
            }

            return "Voo não encontrado!";
        }

        public List<string> ListarBilhetesPorVoo(int idVoo, bool efetivos)
        {
            List<string> listaBilhetes;

            if (efetivos)
            {
                listaBilhetes = BilheteEfe;
            }
            else
            {
                listaBilhetes = Bilhetesuplente;
            }

            List<string> bilhetesDoVoo = new List<string>();

            foreach (var bilhete in listaBilhetes)
            {
                if (bilhete.StartsWith($"{idVoo}-"))
                {
                    bilhetesDoVoo.Add(bilhete);
                }
            }

            return bilhetesDoVoo;
        }

        public List<string> ListarBilhetesPorPassageiro(string nif, bool efetivos)
        {
            List<string> listaBilhetes;

            if (efetivos)
            {
                listaBilhetes = BilheteEfe;
            }
            else
            {
                listaBilhetes = Bilhetesuplente;
            }

            List<string> bilhetesDoPassageiro = new List<string>();

            foreach (var bilhete in listaBilhetes)
            {
                // Agora, verificamos se o bilhete contém a substring "-{nif}-"
                if (bilhete.Contains($"-{nif}"))
                {
                    bilhetesDoPassageiro.Add(bilhete);
                }
            }

            return bilhetesDoPassageiro;
        }


        public string CancelarBilhetes(string nif, bool efetivos, string bilheteSelecionado)
        {
            List<string> listaBilhetes;

            if (efetivos)
            {
                listaBilhetes = BilheteEfe;
            }
            else
            {
                listaBilhetes = Bilhetesuplente;
            }

            // Verifica se o NIF existe nos bilhetes
            bool nifExiste = listaBilhetes.Any(b => b.EndsWith($"-{nif}"));
            if (!nifExiste)
            {
                return "NIF não encontrado nos bilhetes.";
            }

            // Verifica se o bilheteSelecionado existe na lista de bilhetes do passageiro
            if (!listaBilhetes.Contains(bilheteSelecionado))
            {
                return "Bilhete selecionado não encontrado nos bilhetes do passageiro.";
            }

            // Remove o bilhete selecionado
            listaBilhetes.Remove(bilheteSelecionado);

            // Incrementa o número de lugares ou suplentes, dependendo do tipo de bilhete
            if (efetivos)
            {
                foreach (Rota rota in listar_rota())
                {
                    rota.Setn_rota(rota.Getn_rota() + 1);

                    // Incrementar o número de lugares disponíveis
                    foreach (Voo voo in voosPorDestino[rota.GetDestino()])
                    {
                        voo.SetNlugares(voo.GetNlugares() + 1);
                    }

                    break;  // Se encontrou a rota, pode interromper o loop
                }
            }
            else
            {
                foreach (Rota rota in listar_rota())
                {
                    foreach (Voo voo in voosPorDestino[rota.GetDestino()])
                    {
                        voo.SetSuplentes(voo.GetSuplentes() + 1);
                        break;  // Se encontrou o voo, pode interromper o loop
                    }
                    break;  // Se encontrou a rota, pode interromper o loop externo
                }
            }

            return "Bilhete cancelado com sucesso!";
        }

        public DateTime ObterDataPorID(int idVoo)
        {
            foreach (var voosPorDestinoEntry in voosPorDestino)
            {
                foreach (var voo in voosPorDestinoEntry.Value)
                {
                    if (voo.GetIDvoo() == idVoo)
                    {
                        // Retorna a data do voo se encontrado
                        return voo.Getdata();
                    }
                }
            }

            // Retorna DateTime.MinValue se o voo não for encontrado
            return DateTime.MinValue;
        }

        //ler ficheiro bilhete efetivo
        public void LerBilheteEfetivo(string caminhoficheiro)
        {
            try
            {
                

                using (StreamReader sr = new StreamReader(caminhoficheiro))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Divide a linha usando o caractere ';' como separador
                        string[] partes = linha.Split('-');

                        // Verifica se a linha tem o formato esperado
                        if (partes.Length == 2)
                        {
                            // O primeiro elemento é o ID de voo, o segundo é o NIF
                            BilheteEfe.Add($"{partes[0]}-{partes[1]}");
                        }
                        else
                        {
                            MessageBox.Show($"Formato inválido na linha: {linha}");
                        }
                    }
                }

                MessageBox.Show("Lista de Bilhetes carregada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a lista de Bilhetes: {ex.Message}");
            }
        }

        //guardar ficheiro bilhete efetivo
        public void GuardarBilheteEfetivo(string caminhofic)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(caminhofic))
                {
                    foreach (string bilhete in BilheteEfe)
                    {
                        // O formato aqui é "ID_VOO-NIF"
                        sw.WriteLine(bilhete); 
                    }
                }

                MessageBox.Show("Lista de Bilhetes efetivos salva com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a lista de Bilhetes efetivos: {ex.Message}");
            }
        }

        //ler ficheiro bilhete suplente
        public void LerBilheteSuplente(string caminhofi)
        {
            try
            {


                using (StreamReader sr = new StreamReader(caminhofi))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Divide a linha usando o caractere ';' como separador
                        string[] partes = linha.Split('-');

                        // Verifica se a linha tem o formato esperado
                        if (partes.Length == 2)
                        {
                            // O primeiro elemento é o ID de voo, o segundo é o NIF
                            Bilhetesuplente.Add($"{partes[0]}-{partes[1]}");
                        }
                        else
                        {
                            MessageBox.Show($"Formato inválido na linha: {linha}");
                        }
                    }
                }

                MessageBox.Show("Lista de Bilhetes carregada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a lista de Bilhetes: {ex.Message}");
            }
        }

        //guardar ficheiro bilhete suplente
        public void GuardarBilheteSuplente(string caminhofic)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(caminhofic))
                {
                    foreach (string bilhete in Bilhetesuplente)
                    {
                        // O formato aqui é "ID_VOO-NIF"
                        sw.WriteLine(bilhete);
                    }
                }

                MessageBox.Show("Lista de Bilhetes efetivos salva com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a lista de Bilhetes efetivos: {ex.Message}");
            }
        }


    }
}

