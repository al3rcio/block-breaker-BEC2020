[bec2020]: bec.jpg 
![BeC2020][bec2020]

# Bits Breaker 2020
`(título provisório, a definir)`
> Jogo estilo block breaker com tema _2020_, baseado no EP da banda [**Bits em Chamas**](http://bitsemchamas.me "Site Bits em Chamas").

A ideia do jogo é que cada level seja baseado em um som do EP _2020_. A música de cada level/som será a base do respectivo som em loop. Cada level vai ter um array de possíveis sons, dentro de uma pré-definida escala para o level.

Conforme o player for quebrando blocos, acertando a parede etc soará, de maneira randômica, uma dessas notas do array, fazendo com que cada jogador "improvise" uma espécie de "solo" ou arranjo musical em cima da base em loop.


Core do jogo a partir do curso _Complete C# Unity Game Developer 2D_ from [GameDev.tv](https://www.gamedev.tv/)

> contato -> <al3rcio@gmail.com> || twitter -> [@al3rcio](https://twitter.com/al3rcio) 


![TODO](https://hitsperdidos.com/wp-content/uploads/2020/01/Bits-em-Chamas-1536x1536.jpg)
## TODO
- Level design
    - [ ] Criar fase baseada em música
    - [ ] Definir background para cada level
    - [ ] Definir fonte dos textos
    - [ ] Definir paleta de cores por fase

- Sound design
    - [ ] Criar loop base de cada som
    - [ ] Criar array de sons na escala de cada música

- Programação
    - [x] Previnir bola loop infinito
    - [x] Bola inicia com o paddle
    - [x] ~~Instanciar múltiplas bolas~~

- Playtest
    - [ ] Afinar gameplay
    - [ ] Definir níveis de dificuldade
    - [ ] Definir estilo de pontuação
    - [ ] Definir tipo de lista de score

---

 ## Faixas EP
 1. Cave
 2. Ela quer tudo
 3. Frágil equilíbrio
 4. Hello World

```cs
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("Hello World");
        }
    }
}
```

