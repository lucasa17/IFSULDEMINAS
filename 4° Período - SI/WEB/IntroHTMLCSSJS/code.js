function changeColor(){
    p1.style.color = 'red';
}

titulo.addEventListener('click', changeColor);

function addParagraph(){
    const paragraphToBeAdd = document.createElement("p");
    const paragraphToBeAddText = document.createTextNode("Texto para o Paragráfo adicionado.");

    paragraphToBeAdd.appendChild(paragraphToBeAddText);

    document.body.appendChild(paragraphToBeAdd);

}
buttonAddParagraph.addEventListener('click', addParagraph);

function searchAPI(){
    const users_url = "https://jsonplaceholder.typicode.com/users";

    // Requisição HTTP GET {request -> SERVER -> response}
    fetch(users_url)
        .then(response => {
            if(!response.ok){
                throw new Error("Erro ao consultar API.");
            }
            return response.json();
        }).then(data =>{
            const p = document.createElement('p');
            const index = Math.floor(Math.random() * 9);
            const text = document.createTextNode("Nome: "+ data[index].name + "Email: "+ data[index].email);
            p.appendChild(text);
            document.body.appendChild(p);        
        }).catch(error => {
            const p = document.createElement('p');
            const textNode = document.createTextNode(error.message);
            p.appendChild(textNode);
            document.body.appendChild(p);   
        });
}

buttonRemoteQuery.addEventListener('click', searchAPI);
