let currentSelectedElement = null;
let mainTextArea = document.querySelector('#main-text');
let imgSelectElements = document.querySelectorAll('.img-select');
let styleInput = document.querySelector('#style-input');

imgSelectElements.forEach(el => {
    el.addEventListener('click', (e) => {
        mainTextArea.id = el.id;
        
        if(currentSelectedElement != null){
            currentSelectedElement.classList.remove('selected-border');
        }
        
        currentSelectedElement = el;
        currentSelectedElement.classList.add('selected-border');
        
        let background = "{ background-color: " + getComputedStyle(currentSelectedElement).backgroundColor + "; " + "background-image: " + getComputedStyle(currentSelectedElement).backgroundImage + "; }"
        console.log(background);
        styleInput.value = background;
    })
})