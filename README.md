# apbd-cw1-git-s33210
1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
    Fast-forward dzieje się, gdy główna gałąź nie zmieniła się od momentu stworzenia bocznej gałęzi. 
    Merge commit powstaje, gdy na obu gałęziach pojawiły się nowe, niezależne commity.
2. Czym w praktyce różni się merge od rebase?
    Merge łączy gałęzie tworząc nowy commit scalający (zachowuje historię równoległą). 
    Rebase przepisuje historię, przenosząc nasze commity na sam koniec gałęzi docelowej, dzięki czemu historia jest liniowa.