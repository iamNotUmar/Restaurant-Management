function clearScreen() {
    document.getElementById("display").value = "";
}

function display(value) {
    document.getElementById("display").value += value;
}

function calculate() {
    var p = document.getElementById("display").value;

    if (p.includes("cos")) {
        cos();
    } else if (p.includes("sin")) {
        sin();
    } else if (p.includes("tan")) {
        tan();
    } else if (p.includes("^")) {
        power();
    } else {
        var q = eval(p);
        document.getElementById("display").value = q;
    }
}

function cos() {
    let num = document.getElementById("display").value;
    num = num.substring(3);
    let radian = (Math.PI / 180) * num;
    let result = Math.cos(radian);
    document.getElementById("display").value = result;
}

function sin() {
    let num = document.getElementById("display").value;
    num = num.substring(3);
    let radian = (Math.PI / 180) * num;
    let result = Math.sin(radian);
    document.getElementById("display").value = result;
}

function tan() {
    let num = document.getElementById("display").value;
    num = num.substring(3);
    let radian = (Math.PI / 180) * num;
    let result = Math.tan(radian);
    document.getElementById("display").value = result;
}

function power() {
    let value = document.getElementById("display").value;
    let opreator = value.indexOf("^");
    let pow = value.substring(opreator + 1);
    let num = value.slice(0, opreator);
    document.getElementById("display").value = Math.pow(num, pow);
}
