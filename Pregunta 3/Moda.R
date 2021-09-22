v6<-sample(1:20,100,replace = T)
print(v6)
barplot(table(v6))
as.numeric(names(which.max(table(v6))))
print(sort(v6))
x<-as.numeric(names(which.max(table(v6))))
print(x)
c<-0
for (variable in v6) {
  if (variable == x) {
    c = c + 1
  }
}
print(paste("La moda es: ",c))
