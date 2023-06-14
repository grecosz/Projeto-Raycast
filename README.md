# Projeto-Raycast
Desenvolvimento de uma cena utilizando conceitos básicos de raycast. Projeto realizado por Ruan Ruales e Mariana Greco - 3° Jogos.

Desenvolvemos uma cena onde o jogador é capaz de controlar uma nave espacial e destruir planetas com sua colisão. Nossa ideia principal era um jogo 2D, mas achamos que o raycast ficou mais interessante sendo usado em um projeto 3D. 




Há um total de 8 planetas na cena. Quando todos são explodidos, uma mensagem aparece ao jogador informando que ele cumpriu todos os seus objetivos. Para fazer isso utilizamos um if e else relacionado ao raycast.



Utilizamos alguns Assets para a facilitação do projeto, eles estão presentes nos planetas e na nave que o jogador controla.


Movimentação:

Para a nave utilizamos uma movimentação completa, tanto de teclado quanto de mouse, fazendo rotações completas com a possibilidade de ir para todos os lados.

Física:
Para física utilizamos rigidbody nos planetas, sphere colide, materiais e também regulamos a massa de cada um. A nave possui rigidbory, box colider, material e o raycast.

Raycast:
O raycast da nossa cena ocorre da seguinte forma: controlamos nossa nave com o objetivo de acabar com todos os planetas de tal universo. O controle de bordo da nave (console) nos avisa sobre a missão e quando terminamos ele mostra que a tarefa foi concluída. Quando a nave colide com o planeta ele some, função feita pelo raycast.

