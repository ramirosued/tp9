// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let campoContraseña = document.getElementById('contraseña').value;
let campoContraseña2 = document.getElementById('contraseña2').value;
let coinciden;

if(campoContraseña.length > 8){
    coinciden = true
    return coinciden
}

if(campoContraseña == campoContraseña2){
    coinciden = true
    return coinciden
}else{
    contraseñaaa.innerHTML = "Las contraseñas no coinciden"
    coindiden = false
    return coinciden
}