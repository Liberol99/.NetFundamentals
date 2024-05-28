document.addEventListener("DOMContentLoaded", function ()
{
    alert("Hoşgeldin !");
});

function showMessage() {
    alert("Şampiyon Galatasaray");
}

function setLocalStorage(key, jRow) {
    if (jRow != null && key != null) {
        localStorage.setItem(key, jRow);
        alert("kayıt işlemi başarılı");
    }
    else {
        alert("model veya key boş !");
    }
}

function getLocalStorage(key) {
    if (key != null) {
        var data = localStorage.getItem(key);
        return data;
    }
    else {
        alert("key boş !");
    }
}

function removeLocalStorage(key) {
    if (key != null) {
        localStorage.removeItem(key);
        alert("silme işlemi başarılı");
    }
    else {
        alert("key boş !");
    }
}