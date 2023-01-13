let currentSelectedElement = null;
let imgSelectElements = document.querySelectorAll('.img-select');
let styleInput = document.querySelector('#style-input');
let bodyContainer = document.querySelector('#body-container');

imgSelectElements.forEach(el => {
    el.addEventListener('click', (e) => {
        bodyContainer.id = el.id;
        
        if(currentSelectedElement != null){
            currentSelectedElement.classList.remove('selected-border');
        }
        
        currentSelectedElement = el;
        currentSelectedElement.classList.add('selected-border');
        
        let background = "background-color: " + getComputedStyle(currentSelectedElement).backgroundColor + "; " + "background-image: " + getComputedStyle(currentSelectedElement).backgroundImage + ";"
        console.log(background);
        styleInput.value = background;
    })
})