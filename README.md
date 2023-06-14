# Projeto-Raycast
## Desenvolvimento de uma cena utilizando conceitos básicos de raycast. Projeto realizado por Ruan Ruales e Mariana Greco - 3° Jogos.
<br>

### *Introdução*
Desenvolvemos uma cena onde o jogador é capaz de controlar uma nave espacial e destruir planetas com sua colisão. Nossa ideia principal era um jogo 2D, mas achamos que o raycast ficou mais interessante sendo usado em um projeto 3D. O ambiente é simples, simulando o espaço sideral através de luzes e assets diferentes.
<br>
<br>

![ray1](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/ray1.png?raw=true)


### *Jogabilidade*
Há um total de 8 planetas na cena. O objetivo principal é colidir e destruir todos eles, evitando obstáculos que farão com que sua nave perca a estabilidade.
<br>
<br>

![obstáculo](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/obst%C3%A1culo.png?raw=true)


Ao iniciar a cena, o jogador recebe uma mensagem indicando que deve acertar os planetas. Quando todos os planetas são explodidos, uma outra mensagem aparece informando que o jogador cumpriu todos os seus objetivos. Para fazer isso, utilizamos um IF e ELSE relacionado ao raycast que verificava se a quantia de colisões era igual a 8 (número total de planetas).
<br>
<br>

![msg](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/msg.png?raw=true)


### *Assets e Materiais*
Usamos e abusamos dos assets para a facilitação e decoração do projeto, sendo eles presentes nos planetas e na nave que o jogador controla. Além disso, utilizamos alguns materiais para dar mais vida ao projeto, como uma textura de ouro para alguns detalhes da cena.
<br>
<br>

![assets](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/assets.png?raw=true)
![materials](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/materials.png?raw=true)
![planetas](https://github.com/grecosz/Projeto-Raycast/blob/main/Imagens/planetas.png?raw=true)


### *Movimentação*

Programamos nossa nave para que ela pudesse executar uma movimentação completa, utilizando teclado e mouse. Com as teclas W, A, S e D é possível movimentar a nave para cima, esquerda, baixo e direita respectivamente. Com o mouse, é possível mirar na direção que deseja ir, facilitando o controle até o local desejado. Sendo assim, é possível ir para todos os lados com a nave.
<br>
<br>

![assets]

Física:
Para física utilizamos rigidbody nos planetas, sphere colide, materiais e também regulamos a massa de cada um. A nave possui rigidbory, box colider, material e o raycast.

Raycast:
O raycast da nossa cena ocorre da seguinte forma: controlamos nossa nave com o objetivo de acabar com todos os planetas de tal universo. O controle de bordo da nave (console) nos avisa sobre a missão e quando terminamos ele mostra que a tarefa foi concluída. Quando a nave colide com o planeta ele some, função feita pelo raycast.

