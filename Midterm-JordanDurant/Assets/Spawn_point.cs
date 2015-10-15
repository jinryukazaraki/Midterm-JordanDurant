using UnityEngine;
using System.Collections;

public class Spawn_point : MonoBehaviour {

	public Transform prefab;
		
	public IEnumerator Do() {
		yield return new WaitForSeconds(5);    
			// code to be executed after 5 secs
		}
		
		public void Awake() {
			Instantiate(prefab);
			yield return StartCoroutine("Do");
			
		}
	}
	}
}
