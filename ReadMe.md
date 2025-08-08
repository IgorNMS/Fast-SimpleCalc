## Calculadora de terminal simples...

E apenas um projetinho simples, pra atender necessidades minhas, de calcular algo diretamente no terminal.

    - para usar basta digitar:
        SCalc -h => para mostrar mensagem de ajuda.
        SCalc add --a <numero> --b <numero> => para fazer operações de adição.
        SCalc subtc --a <numero> --b <numero> => para fazer operações de subtração.
        SCalc mult --a <numero> --b <numero> => para fazer operações de multiplicação.
        SCalc div --a <numero> --b <numero> => para fazer operações de divisão.

Para fazer o build no linux:

dotnet publish -r linux-x64 -p:PublishSingleFile=true --self-contained false
