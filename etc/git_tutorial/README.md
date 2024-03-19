## Git használati útmutató
**Figyelem:** Ez a leírás nem részletezi a Git vagy Github használatát mélységében, csupán a feladatok megnyitásához és megoldások feltöltéséhez szükséges szinten!

## 1. Félév könyvtár clone-ozása
**Figyelem:** Az útmutató a [Github Desktop](https://desktop.github.com) alkalmazásával mutatja be a könyvtár clone-ozását, valamint kezelését. 
![A félév anyagának Repository-ja](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_repo_main.png)
A félév anyagának Repository-ja
![Github Desktop felület](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_desktop_main.png)
Github Desktop felület

**1. lépés:**

A **zöld "Code" gomb** alatt, az **URL másolásával, vagy az "Open with GitHub Desktop" gomb** megnyomásával indítható a folyamat
![A zöld "Code" gomb alatt, az URL másolásával, vagy az "Open with Github Desktop gomb megnyomásával indítható a folyamat](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_repo_open1.png)

Akármelyik opciót is választottuk, a Github Desktopon ellenőrizzük, hogy megfelelően ki van-e töltve a **Repository URL** és a **Local Path**.

 - **Repository URL** - Innen Clone-ozzuk a könyvtár tartalmát
 - **Local Path** - Itt fogjuk tárolni lokálisan a munkánk során

![gh_clone](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_desktop_clone.png)

Ha minden mező megfelelően van kitöltve, akkor meg is nyomhatjuk a **Clone gombot!**

Ezt követően a **Github Desktop alkalmazásban** már láthatjuk a könyvtárat.

![gh_dekstop_opened](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_desktop_openWithCode.png)

## 2. A könyvtár megnyitása szövegszerkesztőben

![gh_dekstop_opened](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_desktop_openWithCode.png)

Láthatjuk, hogy a könyvtár clone-ozását követően, a jobb oldalon **3 új opciónk is van már:**

 1. **Open the repository in your external editor** - Ezt fogjuk használni most, ez megnyitja az általunk preferált szövegszerkesztőben a könyvtárat, így minden file-t könnyen kezelhetünk benne.
 2. **View the files of your repository in Finder** *(itt ha Önök Windows-t használnak, akkor File Explorer lesz)* - Néha szükséges direktben megnyitni a lokálisan tárolt file-okat, most viszont nem fogjuk ezt használni
 3. **Open the repository page on GitHub in your browser** - Ez a gomb, pedig az én általam készített eredeti könyvtárhoz navigálja Önöket

**Nyomjuk meg az 1-es gombot.**

***Figyelem:** Nálam automatikusan a VSCode-ot választotta a GitHub Desktop, itt a "Preferences" gombbal tudnak állítani rajta, hogy melyik szövegszerkesztőt használják (VSCode-ot javaslom).*

![openedincode](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_vscode1.png)

Ha mindent jól végeztünk, a szövegszerkesztőnkben megnyílik a könyvtár, szabadon szerkeszthetjük azt!

## 3. Feladatok megoldásának feltöltése
Itt lesz egy kicsit bonyolultabb a GitHub, mivel képzeljük el azt a szituációt, hogy Önök 30-an ugyanazt a file-t írják át, más-más megoldásokkal... Pontosan ez fog történni DE! pont az ilyen- és ehhez hasonló helyzetek kezelését segíti elő a Git!

Amikor önök clone-oznak egy könyvtárat és dolgoznak benne (hacsak az nem a saját könyvtáruk), akkor **a módosításokat (Commit), ún. "Pull Request" formában adjuk fel.** A könyvtár tulajdonosa, pedig ezeket áttekintheti és eldöntheti melyik Pull Request-et Merge-eli be az eredeti könyvtárba.

**Írjunk bele tehát a teszt_feladat.cs file-ba bármit, MENTSÜK EL a változtatásokat és próbáljunk meg feladni egy Commit-ot:**
![commit](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_commit.png)

A változtatásaimat a file-okban láthatom is a Github Desktopon, valamint innen tudom indítani a feltöltést a **Commit gombbal.**
*Itt már figyelmeztet minket a Github, hogy nem miénk az adott Master könyvtár, de ez nem probléma!*

1. Szólni fog a Github Desktop, hogy szeretnénk-e "Fork"-olni a könyvtárat.

**Igen.**
![fork1](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_fork.png)

2. Milyen célra Fork-olunk?

**To contribute to the Parent Project**
![fork2](https://github.com/Herkerr/Milton_ProgTech/blob/main/etc/git_tutorial/gh_fork_select.png)
Itt a két opció közötti különbség, hogy egy már létező projekthez szeretnénk mi is hozzáadni kódot, vagy saját projektet készítünk belőle *(pl.: Open Source forrásból saját szoftvert)*
