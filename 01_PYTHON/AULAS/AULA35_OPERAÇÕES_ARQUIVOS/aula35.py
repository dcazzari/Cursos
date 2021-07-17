import os
import json
os.system('cls')

nome="teste"
ext=[".txt",".json"]
arquivoTxt=open("C:/Users/TAMMY/Documents/00 CURSOS/04 PYTHON\AULAS/AULA35_OPERAÇÕES_ARQUIVOS/"+nome+ext[0],"at")
arquivoJson=open("C:/Users/TAMMY/Documents/00 CURSOS/04 PYTHON\AULAS/AULA35_OPERAÇÕES_ARQUIVOS/"+nome+ext[1],"at")

# r = arquivo de leitura
# a = append - andiciona conteudo no arquivo sem alterar o que já estava la
# w = escrita - se o arquivo não existir, é criado automaticamente
# x = criar arquivo
# t = indica que o arquivo é de texto
# b =  indica que o arquivo é binario

conteudoTxt=input("Digite o conteudo do arquivo de texto: ")
arquivoTxt.write(conteudoTxt+"\n")

conteudoJson=json.dumps('{"nome":"Daniel","time":"aviadores","energia":"True","mochila":["pederneira","corda","linha","arame"],"aeronaves":[{"tipo":"transporte","habilidade":80},{"tipo":"ataque","habilidade":100},{"tipo":"reconhecimento","habilidade":50}]}')
arquivoJson.write(conteudoJson+"\n")

arquivoJson.close()
arquivoTxt.close()