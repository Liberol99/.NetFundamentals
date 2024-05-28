function myFunction() {
    let button = document.querySelector('.form-button');    
    button.addEventListener('click', (event) => {
        event.preventDefault();
    });
}
function selectedCheckboxes() {
    let boxes = document.querySelectorAll('input.checked');
}