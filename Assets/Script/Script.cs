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
            Debug.Log("Mordio" + Nombre);
        }

        public virtual void HabilidadEspecial()
        {
            Debug.Log("Ataco con su habileEspecial mordidad venenosos a " + Nombre);
        }
    }



    public class Orco : Enemigo
    {

        public override void HabilidadEspecial()
        {
            Debug.Log("Ataque habiles especial critos a " + Nombre);
        }
    }


    public class Dragon : Enemigo
    {

        public override void HabilidadEspecial()
        {
            Debug.Log("Ataques habiles especial bolas de fuegos a " + Nombre);
        }
    }
}