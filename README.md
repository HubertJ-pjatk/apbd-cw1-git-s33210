# apbd-cw1-git-s33210
1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
    Fast-forward dzieje się, gdy główna gałąź nie zmieniła się od momentu stworzenia bocznej gałęzi. 
    Merge commit powstaje, gdy na obu gałęziach pojawiły się nowe, niezależne commity.
2. Czym w praktyce różni się merge od rebase?
    Merge łączy gałęzie tworząc nowy commit scalający (zachowuje historię równoległą). 
    Rebase przepisuje historię, przenosząc nasze commity na sam koniec gałęzi docelowej, dzięki czemu historia jest liniowa.
3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
    Konflikt wystąpił w pliku Program.cs. 
    Rozwiązałem go korzystając z narzędzia wbudowanego w środowisko Rider (Merge Dialog), gdzie wybralem docelowa wersje kodu.