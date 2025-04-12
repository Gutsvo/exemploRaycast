# exemploRaycast
### Criado por Gabriel Lima Villarinho e Gustavo da Silva Rezende

## Link do projeto

<p>https://drive.google.com/file/d/1FDyJlVU8z1mvMN7b5hQV6qTk5Q_sKMoz/view?usp=drive_link</p>

## scripts

### raycast

<p>Nesse script estamos iniciando o código instanciando as variáveis e inicinando uma CoRoutine para gerar os alvos</p>
![image](https://github.com/Gutsvo/exemploRaycast/blob/main/Screenshots/Captura%20de%20tela%202025-04-11%20121453.png)


<p>No script abaixo checamos o input do usuário, se for o botão esquerdo do mouse o raio é lançado da posição do mouse, se for na barra de espaço o raio é lançado da frente do objeto e se for a tecla enter o raio é lançado do centro da câmera</p>
imagem

<p>Nesse estamos criando o método chamado no script acima, ele coleta os dados do raio e e mostrando eles no console. Também estamos checando com o que o raio colidiu e se for um objeto com a tag "Alvo" o objeto é destruído, mas se não atingir nenhum objeto com essa tag o console mostra sua direção e uma mensagem para mostrar que errou</p>
imagem

<p>Aqui estamos criando o método para mudar o objeto criado na cena para cada um dos inputs e fazendo com que eles fiquem apenas 1 segundo</p>
imagem

<p>Nesse estamos desenhando uma linha vermelha na frente do objeto</p>
imagem

<p>Aqui estamos criando o método para gerar os objetos após a colisão</p>
imagem

<p>Aqui estamos criando um método para instanciar os prefabs criados, ele não foi mais utilizado, pois utilizamos apenas o script acima</p>
imagem

<p>Nesse estamos criando o método para criar os alvos aleatóriamente na cena</p>
imagem

### Movimentação

<p>Aqui instaciamos as variáveis e setando elas para 0</p>
iamgem

<p>Aqui estamos checando o input do usuário e para cada input ele rotaciona para um dos eixos, sendo eles W no eixo X positivo e S negativo, A no eixo Z positivo e D negativo e por fim Q no eixo Y positivo e E negativo</p>
imagem

## Vídeo



https://github.com/user-attachments/assets/05bc85d9-d883-41c7-9811-07dd2a6ab95e

