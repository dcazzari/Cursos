
from canal_module import jogador #importa apena o conteudo de jogador para o código, não precisa mais usar o nome da  biblioteca de origem.
exemplo: print(jogador["nome"])

import canal_module as cm #importa tudo de canal_module e atribui cm como alias
cm.Canal()
print(cm.jogador["nome"])