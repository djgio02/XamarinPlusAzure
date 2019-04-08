using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ListViewSample.Models;
using ListViewSample.Views;
using Xamarin.Forms;

namespace ListViewSample.ViewModels
{
    public class MusicsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Musics> Musics { get; set; } 

        public MusicsViewModel()
        {
            Musics = new ObservableCollection<Musics> 
            {
                new Musics 
                {
                    Picture     = "Music",
                    Name        = "Las Abejas",
                    Description ="Cancion de Juan Luis Guerra"
                },
                new Musics
                {
                    Picture     = "Music",
                    Name        = "Bachata Rosa",
                    Description = "Cancion de Juan Luis Guerra"
                },
                new Musics
                {
                    Picture     = "Music",
                    Name        = "Un hombre normal",
                    Description = "Cancion de Ricardo Montaner 2012"
                },
                new Musics
                {
                    Picture     = "Music",
                    Name        = "La bilirubina Rosa",
                    Description = "Cancion de Juan Luis Guerra"
                },
                new Musics
                {
                    Picture     = "Music",
                    Name        = "Minutos",
                    Description = "Cancion de Ricardo Arjona"
                },
                new Musics
                {
                    Picture     = "Music",
                    Name        = "La cima del cielo",
                    Description = "Cancion de Ricardo Montaner"
                }
            }; 
        } 
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
