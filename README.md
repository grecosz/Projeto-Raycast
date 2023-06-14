# Projeto-Raycast
## Desenvolvimento de uma cena utilizando conceitos básicos de raycast. Projeto realizado por Ruan Ruales e Mariana Greco - 3° Jogos.
<br>

### » ✧ *Introdução* ✧ «
Desenvolvemos uma cena onde o jogador é capaz de controlar uma nave espacial e destruir planetas com sua colisão. Nossa ideia principal era um jogo 2D, mas achamos que o raycast ficou mais interessante sendo usado em um projeto 3D. O ambiente é simples, simulando o espaço sideral através de luzes e assets diferentes.
<br>
<br>

![ray1](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/ray1.png?raw=true)


### » ✧ *Jogabilidade* ✧ «
Há um total de 5 planetas e 1 obstáculo na cena. O objetivo principal é colidir e destruir todos eles, evitando obstáculos que farão com que sua nave perca a estabilidade.
<br>
<br>

![obstáculo](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/obst%C3%A1culo.png?raw=true)


Ao iniciar a cena, o jogador recebe uma mensagem indicando que deve acertar os planetas. Quando todos os planetas são explodidos, uma outra mensagem aparece informando que o jogador cumpriu todos os seus objetivos. Para fazer isso, utilizamos um IF e ELSE relacionado ao raycast que verificava se a quantia de colisões era igual a 5 (número total de planetas).
<br>
<br>

![msg](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/msg.png?raw=true)


### » ✧ *Assets e Materiais* ✧ «
Usamos e abusamos dos assets para a facilitação e decoração do projeto, sendo eles presentes nos planetas e na nave que o jogador controla. Além disso, utilizamos alguns materiais para dar mais vida ao projeto, como uma textura de ouro para alguns detalhes da cena.
<br>
<br>

![assets](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/assets.png?raw=true)
![materials](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/materials.png?raw=true)
![planetas](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/planetas.png?raw=true)

### » ✧ *Iluminação* ✧ «
Utilizamos 2 tipos de iluminação: "directional lights" e "spot lights". A directional light foi usada como uma iluminação primária para que a cena não ficasse escura, enquanto a spot light havia sido usada em tons de roxo e azul com a intenção de dar um efeito mais real de "universo" e "espaço" para nossa cena. Como o projeto acabou pesando com a spot light, decidimos remover do projeto final, deixando apenas a iluminação básica.




### » ✧ *Movimentação* ✧ «

Programamos nossa nave para que ela pudesse executar uma movimentação completa, utilizando teclado e mouse. Com as teclas W, A, S e D é possível movimentar a nave para cima, esquerda, baixo e direita respectivamente. Com o mouse, é possível mirar na direção que deseja ir, facilitando o controle até o local desejado. Sendo assim, é possível ir para todos os lados com a nave.
<br>
<br>


### » ✧ *Física* ✧ «
Para a física da cena, utilizamos rigidbody nos planetas, além do sphere colider e alguns materiais. Também regulamos a massa de cada um para que eles não caíssem no void ou atravessavem uns aos outros. A nave possui rigidbody, box colider, material e o raycast aplicado.

### » ✧ *Raycast* ✧ «
Em nossa cena, o Raycast funciona ao colidirmos com o planeta, deletando-o. Embora seja uma mencânica simples, pudemos compreender muito melhor o uso do Raycast quando aplicamos ela a esta cena.

