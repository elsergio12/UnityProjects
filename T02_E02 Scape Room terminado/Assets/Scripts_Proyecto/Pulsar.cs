using UnityEngine;
using System.Collections;
/*CLASE PULSAR, SIRVE PARA EL BOTON Y LLAMADA AL ASCENSOR*/
public class Pulsar : MonoBehaviour {

	//Variables a utilizar en el script
	[SerializeField]
	private GameObject ContenedorBoton;

	[SerializeField]
	private GameObject ContenedorAscensor;
	private Animation AnimacionBoton;
	private Animation AnimacionAscensor;

	void Start () {
		AnimacionBoton = ContenedorBoton.GetComponent<Animation> ();
		AnimacionAscensor = ContenedorAscensor.GetComponent<Animation> ();

	}
	//Funcion realentizar que se va a utilizar para llamar a esta animacion en el momento que uno la ponga(animation event)
	void realentizar () {
			AnimacionAscensor.Play ("ElevatorUp");
	}
	//Funcion OnTriggerEnter 
	void OnTriggerEnter(Collider collider)
	{
				//utilizo isplaying para que me devuelva un boolean y sepa si la animacion se esta ejecutando o no
				if (AnimacionBoton.isPlaying) {
				} else {
						//Condicion que cuando el Collider identifique al player hara las siguientes animaciones.
						if (collider.name == "Player") {
								//Animacion al apretar el boton
								AnimacionBoton.Play ("Boton");
								//Animacion de bajada de el ascensor
								AnimacionAscensor.Play ("ElevatorDown");
						}
				}
	}
	//Funcion OntriggerExit
	void OnTriggerExit(Collider collider)
				//utilizo isplaying para que me devuelva un boolean y sepa si la animacion se esta ejecutando o no
	{			if (AnimacionBoton.isPlaying) {
				} else {
				//Condicion para saber que cuando el collider haya entrado en colision con el Player y se haya apretado el boton 2 haga lo siguiente:
				if (collider.name == "Player"  && AnimacionBoton.Play ("Boton")) {
						//Animacion de salida del boton.
						AnimacionBoton.Play ("Boton2");
			}
		}
	}
}	