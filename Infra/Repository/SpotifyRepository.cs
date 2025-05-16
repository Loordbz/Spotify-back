using Domain.Interface.Repository;
using Domain.Models;

namespace Infra.Repository;

public class SpotifyRepository : ISpotifyRepository
{
    public async Task<IEnumerable<Album?>?> GetAlbums()
    {
        await Task.Delay(300);
        return new List<Album>
        {
            new Album {
                Name = "White Noise (Sleep & Relaxation Sounds)",
                Url = "https://i.ibb.co/WBgGp5q/album-white-noise.jpg",
                Artist = "Sleepy John"
            },
            new Album {
                Name = "O Céu Explica Tudo (Ao Vivo)",
                Url = "https://i.ibb.co/BfbL8VL/album-ceu-explica.jpg",
                Artist = "Henrique & Juliano"
            },
            new Album {
                Name = "Nada como um dia após o outro",
                Url = "https://i.ibb.co/MDZt76D/album-racionais.jpg",
                Artist = "Racionais"
            },
            new Album {
                Name = "Hit me hard and soft",
                Url = "https://i.ibb.co/G3kXhXc/album-hit-me.jpg",
                Artist = "Billie Eilish"
            },
            new Album {
                Name = "Caju",
                Url = "https://i.ibb.co/B3b0N7H/album-caju.jpg",
                Artist = "Liniker"
            },
            new Album {
                Name = "Escândulo Íntimo",
                Url = "https://i.ibb.co/VMnCmTX/album-escandalo.jpg",
                Artist = "Luísa Sonza"
            },
            new Album {
                Name = "333",
                Url = "https://i.scdn.co/image/ab67616d00001e0263ecdc2fc549275b51fbb9a7",
                Artist = "Matuê"
            },
        };

    }

    public async Task<IEnumerable<Artist?>?> GetArtists()
    {
        await Task.Delay(300);
        return new List<Artist>
        {
            new Artist {
                Name = "Zé Neto & Cristiano",
                Url = "https://i.ibb.co/7z7CZ69/artista-ze-neto.jpg"
            },
            new Artist
            {
                Name = "Luan Santana",
                Url = "https://i.ibb.co/MSbmBzH/artista-luan-santana.jpg"
            },
            new Artist
            {
                Name = "Jorge & Mateus",
                Url = "https://i.ibb.co/2WfJ8tD/artista-jorge-mateus.jpg"
            },
            new Artist
            {
                Name = "Henrique & Juliano",
                Url = "https://i.ibb.co/wCpHtfQ/artista-henrique-juliano.jpg"
            },
            new Artist
            {
                Name = "Gustavo Lima",
                Url = "https://i.ibb.co/XJP8Djh/artista-gustavo-limma.jpg"
            },
            new Artist
            {
                Name = "Grupo Menos É Mais",
                Url = "https://i.scdn.co/image/ab67616100005174a07c8e41774e3bd6b20f13e3"
            },
            new Artist
            {
                Name =  "Lady Gaga",
                Url = "https://i.scdn.co/image/ab67616100005174aadc18cac8d48124357c38e6"
            }
        };
    }

    public async Task<Insight?> GetInsights()
    {
        await Task.Delay(600);
        return new Insight
        {
            MinuteChart = new MinuteChart
            {
                Month = new List<string> { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho" },
                Results = new List<int> { 278, 628, 234, 317, 306, 210, 217 },
                BackgroundColor = new List<string>
                {
                    "rgba(255, 99, 132, 0.6)",
                    "rgba(255, 159, 64, 0.6)",
                    "rgba(255, 205, 86, 0.6)",
                    "rgba(75, 192, 192, 0.6)",
                    "rgba(54, 162, 235, 0.6)",
                    "rgba(153, 102, 255, 0.6)",
                    "rgba(201, 203, 207, 0.6)"
                },
                BorderColor = new List<string>
                {
                    "rgba(255, 99, 132)",
                    "rgba(255, 159, 64)",
                    "rgba(255, 205, 86)",
                    "rgba(75, 192, 192)",
                    "rgba(54, 162, 235)",
                    "rgba(153, 102, 255)",
                    "rgba(201, 203, 207)"
                }
            },
            MusicChart = new MusicChart
            {
                Music = new List<string>
                {
                    "Come as you are - Nirvana",
                    "TNT - AC/DC",
                    "Nothing else matters - Metallica",
                    "The Trooper - Iron Maiden",
                    "Black - Pearl Jam"
                },
                Results = new List<int> { 234, 210, 174, 167, 100 },
                BackgroundColor = new List<string>
                {
                    "rgba(74, 237, 215, 0.6)",
                    "rgba(112, 86, 71, 0.6)",
                    "rgba(237, 109, 74, 0.6)",
                    "rgba(255, 202, 100, 0.6)",
                    "rgba(63, 217, 127, 0.6)"
                },
                BorderColor = new List<string>
                {
                    "rgba(74, 237, 215)",
                    "rgba(112, 86, 71)",
                    "rgba(237, 109, 74)",
                    "rgba(255, 202, 100)",
                    "rgba(63, 217, 127)"
                }
            },
            StyleChart = new StyleChart
            {
                Style = new List<string> { "Rock Classics", "Eletronics", "Top Hits", "Pagode", "MPB" },
                Results = new List<int> { 320, 140, 100, 70, 45 },
                BackgroundColor = new List<string>
                {
                    "rgb(201, 203, 207)",
                    "rgb(75, 192, 192)",
                    "rgb(255, 205, 86)",
                    "rgb(54, 162, 235)",
                    "rgb(153, 102, 255)"
                }
            },
            NewStyleChart = new NewStyleChart
            {
                Style = new List<string> { "Rock Classics", "Eletronics", "Top Hits", "Pagode", "MPB" },
                Results = new List<int> { 5, 42, 25, 12, 22 },
                BackgroundColor = new List<string>
                {
                    "rgb(85, 27, 179)",
                    "rgb(38, 143, 190)",
                    "rgb(255, 205, 86)",
                    "rgb(44, 184, 178)",
                    "rgb(169, 240, 77)"
                }
            }
        };


    }


    public async Task<IEnumerable<Music?>?> GetMusics()
    {
        await Task.Delay(300);
        return new List<Music>
        {
            new Music {
                Name = "Ta Rico Os Menino do Gueto 🍀",
                Url = "https://i.scdn.co/image/ab67616d00001e02be7c0fb60f9f2bf191d3aecf",
                Artist = new List<string> { "Mc", "IG", "Mc Ryan SP", "Mc Lele JP", "TrapLaudo" },
                IsMusic = true,
            },
            new Music {
                Name = "Cara da Serenata - Live",
                Url = "https://i.scdn.co/image/ab67616d00001e0295e1ac2de526a4e90095dfdd",
                Artist = new List<string> { "Luccas & Rodrigo", "Vitor e Luan" },
                IsMusic = true
            },
            new Music {
                Name = "P do Pecado - Ao Vivo",
                Url = "https://i.scdn.co/image/ab67616d00001e023eb9bb75e0b5472777ba0291",
                Artist = new List<string> { "Grupo Menos É Mais", "Simone Mendes" },
                IsMusic = true
            },
            new Music {
                Name = "Senta e Cala a Boca",
                Url = "https://i.scdn.co/image/ab67616d00001e02a5bd8c7ba1685eedaac14b1b",
                Artist = new List<string> { "Mc Jacaré", "DJ JHOW BEATS" },
                IsMusic = true
            },
            new Music {
                Name = "Braba No Chá",
                Url = "https://i.scdn.co/image/ab67616d00001e0291b3888332182a559fecda7b",
                Artist = new List<string> { "DJ CZ", "MC Nito", "DJ TS", "DJ DUARTE" },
                IsMusic = true
            },
            new Music {
                Name = "Cachorrinha de Madame",
                Url = "https://i.scdn.co/image/ab67616d00001e02c73cdea24607750ad1b6f14d",
                Artist = new List<string> { "DJ DUARTE", "DJ TS", "Mc Gw", "Pollini" },
                IsMusic = true
            },
            new Music {
                Name = "FAMOSINHA",
                Url = "https://i.scdn.co/image/ab67616d00001e0272e0596789ba69a65f8cf075",
                Artist = new List<string> { "Dj Caio Vieira", "MC Meno K", "Mc Rodrigo do CN" },
                IsMusic = true
            },
        };
    }
}