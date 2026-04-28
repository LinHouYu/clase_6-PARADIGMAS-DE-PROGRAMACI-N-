using UnityEngine;

public class Script : MonoBehaviour
{
    public abstract class Personaje
    {
        public string Nombre;
        public abstract void Atacar();
    }

    public class Heroe : Personaje
    {
        public override void Atacar()
        {
            Debug.Log(Nombre + "ataco!");
        }
    }

    public class Enemigo : Personaje
    {
        public override void Atacar()
        {
            Debug.Log("Morder a" + Nombre);
        }
    }
}