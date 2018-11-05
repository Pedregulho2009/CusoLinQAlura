using CursoLinQAlura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace CursoLinQAlura
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pegando dados de estruturas internas
            ////listar os generos rock
            //var generos = new List<Genero> {
            //    new Genero {Id = 1, Nome = "Rock" },
            //    new Genero {Id = 2, Nome = "Reggae"},
            //    new Genero {Id = 3, Nome = "Rock Progressivo"},
            //    new Genero {Id = 4, Nome = "Punk Rock"},
            //    new Genero {Id = 5, Nome = "Clássica" }
            //};

            //foreach (var genero in generos)
            //{
            //    if (genero.Nome.Contains("Rock"))
            //    {
            //        Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
            //    }
            //}
            //Console.WriteLine();

            //var query = from g in generos
            //            where g.Nome.Contains("Rock")
            //            select g;
            //foreach (var genero in query)
            //{
            //    Console.WriteLine("{0}\t{1}", genero.Id, genero.Nome);
            //}

            ////listar musicas 
            //var musicas = new List<Musica>
            //{
            //    new Musica { Id = 1, Nome = "Sweet Child O'Mine", GeneroId = 1 },
            //    new Musica { Id = 2, Nome = "I Shoot The Sheriff", GeneroId = 2},
            //    new Musica { Id = 3, Nome = "Danúbio Azul", GeneroId = 5},
            //};

            //Console.WriteLine();

            //var musicaQuery = from m in musicas
            //                  join g in generos on m.GeneroId equals g.Id
            //                  select new { m, g };
            //foreach (var musica in musicaQuery)
            //{
            //    Console.WriteLine("{0}\t{1}\t{2}",musica.m.Id,musica.m.Nome,musica.g.Nome);
            //}
            #endregion

            #region Pegando dados de estrutura XML

            //XElement root = XElement.Load(@"c:\users\pedro\documents\visual studio 2015\Projects\CursoLinQAlura\CursoLinQAlura\Data\AluraTunes.xml");

            //var querySQL =
            //    from g in root.Element("Generos").Elements("Genero")
            //    select g;

            //foreach (var genero in querySQL)
            //{
            //    Console.WriteLine("{0}\t{1}",genero.Element("GeneroId").Value, genero.Element("Nome").Value);
            //}
            #endregion

            #region Pegando dados de um banco de dados SQL
            using (var contexto = new AluraTunes1Entities())
            {
                //var query = from g in contexto.Generos
                //            select g;

                //foreach (var genero in query)
                //{
                //    Console.WriteLine("{0}\t{1}", genero.GeneroId, genero.Nome);
                //}


                //var faixaEgenero = from g in contexto.Generos
                //                   join f in contexto.Faixas
                //                   on g.GeneroId equals f.GeneroId
                //                   select new { f, g };

                //faixaEgenero = faixaEgenero.Take(10);

                //Console.WriteLine();


                //foreach (var item in faixaEgenero)
                //{
                //    Console.WriteLine("{0}\t{1}", item.f.Nome, item.g.Nome);
                //}
            }
            #endregion

            #region Consultando banco por strings especificas

            //using (var contexto = new AluraTunes1Entities())
            //{
            //    var textoBusca = "Led";
            //    var buscaAlbum = "";


            #region LISTANDO NOME DE ARTISTAS E SEUS ALBUNS A PARTIR DE UM TEXTO DADO PELO USUÁRIO
            //var query = from a in contexto.Artistas
            //            join alb in contexto.Albums
            //                on a.ArtistaId equals alb.ArtistaId
            //            where a.Nome.Contains(textoBusca)
            //            select new
            //            {
            //                NomeArtista = a.Nome,
            //                NomeAlbum = alb.Titulo
            //            };
            // 
            //foreach (var item in query)
            //{
            //    Console.WriteLine("{0}\t{1}", item.NomeAlbum, item.NomeArtista);
            //}
            #endregion

            #region RECEBENDO LISTA DE ARTISTA E SEUS Id A PARTIR DO TEXTO DADO PELO USUÁRIO                
            //var query2 = contexto.Artistas.Where(a => a.Nome.Contains(textoBusca));

            //Console.WriteLine();

            //foreach (var artista in query)
            //{
            //    Console.WriteLine("{0}\t{1}", artista.ArtistaId, artista.Nome);
            //}
            #endregion

            #region ACESSANDO DADOS E PROPRIEDADE DA CLASSE PAI A PARTIR DA CLASSE FILHO

            //var query2 = from alb in contexto.Albums
            //             where alb.Artista.Nome.Contains(textoBusca)
            //             select new
            //             {
            //                 NomeArtista = alb.Artista.Nome,
            //                 NomeAlbum = alb.Titulo
            //             };

            //foreach (var item in query2)
            //{
            //    Console.WriteLine("{0}\t{1}",item.NomeArtista, item.NomeAlbum);                    
            //}
            #endregion

            #region PASSANDO DOIS DADOS PARA CONSULTAR DADOS NO BANCO
            //GetFaixas(contexto, "Led", "Graffiti");
            #endregion
            //}
            #endregion

            #region Fazendo contagem de informações no banco

            //using (var contexto = new AluraTunes1Entities())
            //{
            //    var query = from f in contexto.Faixas
            //                where f.Album.Artista.Nome == "Led Zeppelin"
            //        select f;
            //    var quantidade = contexto.Faixas.Count(f => f.Album.Artista.Nome == "Led Zeppelin");
            //    Console.WriteLine("Led Zeppelin tem {0} musicas no banco de dados.", quantidade);
            //    //var quantidade = query.Count();
            //    //Console.WriteLine("Led Zeppelin tem {0} musicas no banco de dados.",quantidade);
            //    //foreach (var faixa in query)
            //    //{
            //    //    Console.WriteLine(faixa.Nome);
            //    //}
            //}
            #endregion

            #region Contantando quantidades de faixas vendidas por um artista

            //using (var contexto = new AluraTunes1Entities())
            //{
            //    var query = from inf in contexto.ItemNotaFiscals
            //                where inf.Faixa.Album.Artista.Nome == "Led Zeppelin"
            //                select new { totalDoItem = inf.Quantidade * inf.PrecoUnitario};

            //    //foreach (var inf in query)
            //    //{
            //    //    Console.WriteLine("{0}",inf.totalDoItem);
            //    //}
            //    var totalDoArtista = query.Sum(q=> q.totalDoItem);
            //    Console.WriteLine("Total do artista {0}", totalDoArtista);
            //}
            #endregion

            #region Albuns mais vendidos de um artista

            //using (var contexto = new AluraTunes1Entities())
            //{
            //    var query = from inf in contexto.ItemNotaFiscals
            //                where inf.Faixa.Album.Artista.Nome == "Led Zeppelin"
            //                group inf by inf.Faixa.Album into agrupado
            //                let VendasPorAlmbum = agrupado.Sum(a => a.Quantidade * a.PrecoUnitario)
            //                orderby VendasPorAlmbum
            //                descending 
            //                select new
            //                {
            //                    TituloDoAlbum = agrupado.Key.Titulo,
            //                    TotalPorAlbum = VendasPorAlmbum
            //                };
            //    foreach (var agrupado in query)
            //    {
            //        Console.WriteLine("{0}\t{1}",agrupado.TituloDoAlbum.PadRight(40),agrupado.TotalPorAlbum);
            //    }
            //}
            #endregion

            #region Seleciona as vendas: maior, menos e media.

            //using (var contexto = new AluraTunes1Entities())
            //{
            //    var maiorVenda = contexto.NotaFiscals.Max(nf => nf.Total);
            //    var menorVenda = contexto.NotaFiscals.Min(nf => nf.Total);
            //    var vendaMedia = contexto.NotaFiscals.Average(nf => nf.Total);

            //    Console.WriteLine("A maior venda é de R$ {0}", maiorVenda);
            //    Console.WriteLine("A menor venda é de R$ {0}", menorVenda);
            //    Console.WriteLine("A venda média é de R$ {0}", vendaMedia);

            //    var vendas = (from nf in contexto.NotaFiscals
            //        group nf by 1
            //        into agrupado
            //        select new
            //    {
            //        maiorVenda = agrupado.Max(nf => nf.Total),
            //        menorVenda = agrupado.Min(nf => nf.Total),
            //        vendaMedia = agrupado.Average(nf => nf.Total)
            //    }).Single();

            //    Console.WriteLine("A maior venda é de R$ {0}", vendas.maiorVenda);
            //    Console.WriteLine("A menor venda é de R$ {0}", vendas.menorVenda);
            //    Console.WriteLine("A venda média é de R$ {0}", vendas.vendaMedia);
            //}

            #endregion

            #region Manipulando as dados estatisticamente

            //using (var contexto = new AluraTunes1Entities())
            //{
            //    var query = from ng in contexto.NotaFiscals
            //                select ng;

            //    var contagem = query.Count();

            //    var elementoCentral = query.Skip(contagem/2);

            //    var mediana = elementoCentral;

            //    Console.WriteLine("Mediana: {0}", mediana);
            //}

            #endregion
            Console.ReadKey();
        }

        #region FUNCAO PARA PEGAR FAIXAS E SEUS RESPECTIVOS ARTISTAS
        //private static void GetFaixas(AluraTunes1Entities contexto, string textoBusca, string buscaAlbum)
        //{
        //    var query = from f in contexto.Faixas
        //                where f.Album.Artista.Nome.Contains(textoBusca)
        //                select f;

        //    if (!string.IsNullOrEmpty(buscaAlbum))
        //    {
        //        query = query.Where(a => a.Album.Titulo.Contains(buscaAlbum));
        //    }

        //    query.OrderBy(q => q.Album.Titulo).ThenByDescending(q=>q.Nome);
        //    foreach (var faixa in query)
        //    {
        //        Console.WriteLine("{0}\t{1}", faixa.Album.Titulo.PadRight(40), faixa.Nome);
        //    }
        //}
        #endregion
    }
    #region Classes a serem acessandas internamentes 

    //class Genero
    //{
    //    public int Id { get; set; }
    //    public string Nome { get; set; }
    //}

    //class Musica
    //{
    //    public int Id { get; set; }
    //    public string Nome { get; set; }
    //    public int GeneroId { get; set; }
    //}
    #endregion
}

