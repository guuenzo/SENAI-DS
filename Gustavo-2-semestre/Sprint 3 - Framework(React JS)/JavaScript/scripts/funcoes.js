function calcular() {
    event.preventDefault();//Para o submit do formulario

    let n1 = parseFloat(document.getElementById("numero1").value);
    let n2 = parseFloat(document.getElementById("numero2").value);
    let res; //undefined 
    let op = document.getElementById("operacao").value;

    if(isNaN(n1) || isNaN(n2)){
        alert("Preencha todos os campos")
        return;
    }

    switch (op) {
        case "+":
            res = somar(n1, n2)
            break;
        case "-":
            res = subtrair(n1, n2)
            break;
        case "*":
            res = multiplicar(n1, n2)
            break;
        case "/":
            res = dividir(n1, n2)
            break;
        default: res = "Operação inválida"
            break;
    }

    document.getElementById('resultado').innerText = res;

}//Fim da funcao calcular

function somar(x, y) {
    return (x + y).toFixed(2);
}

function subtrair(x, y) {
    return (x - y).toFixed(2);
}

function multiplicar(x, y) {
    return (x * y).toFixed(2);
}

function dividir(x, y) {
    if (y == 0) {
        return "Não é possível dividir por 0!!";
    }

    return (x / y).toFixed(2);
}