#pragma strict

var flickering : boolean = true;
 
function Start() {
    flickerLight();
}
 
function Update () {
 
}
 
function flickerLight() {
 
    while(flickering) {
        yield WaitForSeconds(0.075);
        gameObject.GetComponent.<Light>().intensity += 5;
        yield WaitForSeconds(0.075);
        gameObject.GetComponent.<Light>().intensity = 0;
    }
}