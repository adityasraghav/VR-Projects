#pragma strict

var flickering : boolean = true;
 
function Start() {
    flickerLight();
}
 
function Update () {
 
}
 
function flickerLight() {
 
    while(flickering) {
        yield WaitForSeconds(0.1);
        gameObject.GetComponent.<Renderer> ().enabled = false;
        yield WaitForSeconds(0.1);
        gameObject.GetComponent.<Renderer> ().enabled = true;
        }
}