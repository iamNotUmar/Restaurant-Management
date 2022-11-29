var form = document.getElementById("form");

form.addEventListener("submit", function (event) {
    event.preventDefault();

    if (firstName()) {
        if (lastName()) {
            if (emailCheck()) {
                if (phone()) {
                    open("cal", "_self");
                }
            }
        }
    }
});

function firstName() {
    var fname = document.getElementById("fname");
    if (fname.value.length == 0) {
        alert("Enter First Name!");
        return false;
    } else if (/^[A-Za-z\s]+$/.test(fname.value)) {
        return true;
    } else {
        alert("Invalid first name");
        return false;
    }
}

function lastName() {
    var lname = document.getElementById("lname");
    if (lname.value.length == 0) {
        alert("Enter Last Name!");
        return false;
    } else if (/^[A-Za-z\s]+$/.test(lname.value)) {
        return true;
    } else {
        alert("Invalid last name");
        return false;
    }
}

function emailCheck() {
    var email = document.getElementById("email");
    if (email.value.length == 0) {
        alert("Enter email address !");
        return false;
    } else if (
        /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email.value)
    ) {
        return true;
    } else {
        alert("Plese enter valid email");
        return false;
    }
}

function phone() {
    var phone = document.getElementById("phone").value;

    if (phone.length == 10) {
        if (/^\d{10}$/.test(phone)) {
            return true;
        } else {
            alert("Invalid phone number");
            return false;
        }
    } else if (phone.length == 0) {
        alert("Enter phone number");
        return false;
    } else {
        alert("Phone number length must be 10");
        return false;
    }
}
