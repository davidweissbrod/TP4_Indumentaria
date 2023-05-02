public class Indumentaria{
    
    public string medias {get; private set;}
    public string pantalon {get; private set;}
    public string remera {get; private set;}
}
public static class Equipos{
    list<string> ListaEquipos{get;private set;} 
    list<string> ListaMedias{get; private set;}
    list<string> ListaPantalones{get;private set;}
    list<string> ListaRemeras{get;private set;}
    dictionary<string,Indumentaria> EquiposIndumentaria{get;private set}

    bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item){
        foreach(string item in EquiposIndumentaria.Keys){
            EquiposIndumentaria.Add(equipoSeleccionado, item);
        }
        return true;
    }
}