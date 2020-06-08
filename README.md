# COMANDOS PARA REALIZAR UN MERGE

1. Clonar Nuestro Repositorio
```
git clone <link repositorio>
```
2. Crear una Branch 
```
git checkout -b <nombrebranch>
```

3. Añadir los archivos a nuestra nueva branch
```
git status
```

```
git add .
```

4. Hacer nuestro Commit

```
git commit -m "Cambios Realizados"
```

5. Hacer el push a nuestra Branch
```
git push -u origin <nombrebranch>
```

6. Cambiar a la Branch Master
```
git checkout master
```

7. Hacer el Merge a Master
```
git merge <nombrebranch>
```
