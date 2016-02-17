#pragma strict
 
public var speed : float = 10.0;
public var rotationSpeed : float = 100.0;

 
function Start() {
}
 
function Update() {
    var translation : float = Input.GetAxis ("Vertical") * speed;
    var rotation : float = Input.GetAxis ("Horizontal") * rotationSpeed;
    translation *= Time.deltaTime;
    rotation *= Time.deltaTime;
    transform.Translate (0, translation, 0);
    transform.Rotate (0, 0, -rotation);
}