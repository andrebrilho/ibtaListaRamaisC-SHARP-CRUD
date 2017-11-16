# Contribuindo
Neste projeto é utilizado um framework para organizar melhor o repositório muito utilizado pelas empresas, chamado gitflow.

Para desenvolvedores back-end e front-end
1. No seu terminal digite o comando `git flow` e deixe todas as opções no default(tecle [Enter])
4. Crie as suas features `git flow feature start <nome-da-feature>`
5. Adicione as modificações na stage area `git add .`
6. Commit as suas features `git commit -m "<sua-mensagem>`
7. Caso seja necessário, publique suas features para que outras pessoas possam ajudar `git flow publish feature`
8. Quando suas features estiverem prontas finalize elas `git flow feature finish <nome-da-feature>`
9. Caso seja necessário, crie uma release `git flow release start <nome-da-release>`
10. Caso seja necessário, publique sua release para que outras pessoas possam ajudar `git flow release publish <
nome-da-feature>`
11. Quando a release estiver pronta finalize ela `git flow release finish <nome-da-release>`
12. Tecle [A] para editar o arquivo de texto e descrever a sua release em seguida tecle [ESC] e encerre digitando :wq ou deixe o texto padrão e prossiga digitando [:wq] e sua release será mesclada com as branchs developer e master
13. Crie uma tag pra release.Nomeie suas releases com tags utilizando o padrão de nomenclatura de acordo com a sua realease(Ex: v1.0.0) fazendo o mesmo processo que descrito no passo 12
14. Faça o mesmo para os processos descrito nos passos 12 e 13 só que com o caso do merge de tag de master para develop
15. Aponte o repositório local para o remoto `git remote add origin https://github.com/usuario/repositorio.git` 
16. Faça o push de todas a suas branchs modificadas `git push origin <nome-da-branch>` 
17. Pronto :)

