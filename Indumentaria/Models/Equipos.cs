public class Indumentaria{
    
    public string medias {get; private set;}
    public string pantalon {get; private set;}
    public string remera {get; private set;}


public Indumentaria(string medias, string pantalon, string remera){
    medias = medias;
    pantalon = pantalon;
    remera = remera;
}
}   


public static class Equipos{
    list<string> listaEquipos{get;private set;} = new list<string>{ "River", "Boca", "Racing", "San descenso", "San Telmo", "Atlanta", "Independiente"};
    list<string> listaMedias{get; private set;} = new list<string>{"wwwroot/medias_rojas", "wwwroot/medias_azul", "wwwroot/medias_fluor", "wwwroot/medias_rositas", "wwwroot/medias_violetas", "wwwroot/medias_negras", "wwwroot/medias_verdes"};
    list<string> listaPantalones{get;private set;} = new list<string>{"wwwroot/short_celeste", "wwwroot/short_bordo", "wwwroot/short_fluor", "wwwroot/short_azul", "wwwroot/short_negro", "wwwroot/short_verde", "wwwroot/short_blanco"};
    list<string> listaRemeras{get;private set;} = new list <string>{"wwwroot/camiseta_blanca", "wwwroot/camiseta_byn","wwwroot/camiseta_degrade","wwwroot/camiseta_byr","wwwroot/camiseta_degrade_celeste","wwwroot/camiseta_ryc","wwwroot/camiseta_vyb"};
    dictionary<string,Indumentaria> equiposIndumentaria{get;private set;} = new dictionary<string, Indumentaria>();

    bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item){
        foreach(string item in equiposIndumentaria.Keys){
            equiposIndumentaria.Add(equipoSeleccionado, item);
        }
        return true;
    }
}