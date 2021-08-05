var delegates = [];
function salvar(){
    let id = parseInt(document.getElementById('id').value);
    let nome = document.getElementById('nome').value;
    let apelido = document.getElementById('apelido').value;
    delegado = {'id':id, 'nome':nome, 'apelido':apelido};
    delegates.push(delegado);
    localStorage.setItem('delegates', JSON.stringify(delegates));
    console.log(delegates);
}
function carregarTabela(){
    let tabela = document.getElementsByTagName('tbody')[0];
    delegates.forEach(d => {
        tabela.innerHTML += `<tr><td>${d.id}</td><td>${d.nome}</td><td>${d.apelido}</td></tr>`
    });   
}
window.onload = function(){
    let lista = localStorage.getItem('delegates')
    if(lista != null){
        delegates = JSON.parse(lista);
    }
}