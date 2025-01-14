# SanzMajoleroDavid_M17UF2E1

1.Explica com s’ha aconseguit l’efecte de la barra de potència quan s’augmenta l’escala.

S’augmenta gràcies al mètode CalculateBarScale(), i ho fa de esquerra a dreta gràcies a l’assignació que es fa al mètode Awake(). Després al utilitzar “Mathf.Lerp” li assignem els valors entre el que augmentarà i disminuirà la barra.


Un cop feta la simulació podeu provar els següents casos en l’escena per contestar les preguntes:

2.Com podriem fer que les bales caiguin més ràpid o més lent?

Per fer que les bales caiguin més ràpid o més lent, hauríem d'ajustar la gravetat a l’escena.El valor per defecte es -9.8 m/s², però es pot modificar mitjançant la configuració del "Physics2D.gravity" o mitjançant un script que apliqui una acceleració vertical addicional a les bales. Perquè caiguin més ràpid o més lent podem augmentar o disminuir la gravetat


3.Si canviem la massa de la bala, afecta al moviment d'aquesta?

No afecta ja que a Unity el moviment de la bala quan cau no depèn directament de la seva massa, sino que tots els objectes cauen amb la mateixa acceleració a causa de la gravetat.


4.Si canviem la massa de la bala, afecta al moviment de les capses en els xocs?

Si, si augmentem la massa les capses surten disparades més lluny degut a la col·lisió.


5.Què passa si canviem la fricció de les capses? linear drag i angular drag?

El linear drag i el angular drag són propietats que afecten la resistència al moviment d'un objecte.
El linear drag s'aplica al moviment rectilini d'un objecte, reduint la seva velocitat al llarg del temps.
El angular drag afecta la rotació de l'objecte.
Augmentar linear drag fa que l'objecte es freni més ràpidament en línia recta.
Augmentar angular drag fa que l'objecte perdi velocitat rotacional més ràpidament.
Reduir aquests valors fa que l'objecte sigui més resistent al frenat, movent-se més ràpidament en línia recta o rotant durant més temps.


6.Què passa si afegim a les bales un Physics material 2D amb Bounciness =1 / Bounciness = 0?

El material el que fá es modificar la física a l'objecte al que se li aplica, en aquest cas les bales rebotaràn més o menys segons el Bounciness

