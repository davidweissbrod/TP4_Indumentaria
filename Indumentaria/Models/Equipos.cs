using System.Collections.Generic;

public class Indumentaria{
    
    public string medias {get; private set;}
    public string pantalon {get; private set;}
    public string remera {get; private set;}


public Indumentaria(string medias, string pantalon, string remera){
    medias = medias;
    pantalon = pantalon;
    remera = remera;
}

public Indumentaria(string medias, string pantalon, string remera){


}
}  

public static class Equipos{
    public static List<string> listaEquipos{get;private set;} = new List<string>{ "River", "Boca", "Racing", "San descenso", "San Telmo", "Atlanta", "Independiente"};
    public static List<string> listaMedias{get; private set;} = new List<string>{"medias_rojo.jpg", "medias_azul.webp", "medias_fluor.jpg", "medias_rositas.jfif", "medias_violetas.jfif", "medias_negras.webp", "medias_verdes.jfif"};
    public static List<string> listaPantalones{get;private set;} = new List<string>{"short_celeste.jpg", "short_bordo.jpg", "short_fluor.jpg", "short_azul.jfif", "short_negro.jpg", "short_verde.jfif", "short_blanco.webp"};
    public static List<string> listaRemeras{get;private set;} = new List<string>{"camiseta_blanca.jpg", "camiseta_byn.jfif","camiseta_degrade.jfif","camiseta_byr.jpg","camiseta_degrade_celeste.jpg","camiseta_ryc.jfif","camiseta_vyb.jpg"};
    public static Dictionary<string,Indumentaria> equiposIndumentaria{get;private set;} = new Dictionary<string, Indumentaria>();

    static bool IngresarIndumentaria(int equipoSeleccionado, Indumentaria item){
    foreach(string item in equiposIndumentaria.Keys){
        if(equiposIndumentaria.ContainsKey(equiposIndumentaria.Key)){
            return false;
        }
        else{
            equiposIndumentaria.Add(equipoSeleccionado, item);
            return true;
        }
    }    
}
}

