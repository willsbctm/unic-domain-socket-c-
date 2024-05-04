# Unix Domain Socket

Unix Domain Socket é um mecanismo de comunicação inter processo bidirecional (IPC inter-process comuncation).
Ele é limitado a processos dentro da mesma máquina.
É definido em arquivo físico e pode contar com o permissionamento via file system.

## Unix Domain Socket x TCP/IP

O protocolo TCP/IP resolve muito bem os problemas de comunicação inter máquinas. Para isso, conta com a interface de rede. 
Ao realizar uma chamada TCP/IP dentro da mesma máquina, é usada usada uma interface de rede virtual chamada de `loopback`.

Para a interface loopback é geralmente reservado o range 127.0.0.0/8 e costuma-se atribuir o IP 127.0.0.1 com alias `localhost`

Pare ver a rede loopback:

```sh
$ ifconfig | grep LOOPBACK -A 8
lo: flags=73<UP,LOOPBACK,RUNNING>  mtu 65536
        inet 127.0.0.1  netmask 255.0.0.0
        inet6 ::1  prefixlen 128  scopeid 0x10<host>
        loop  txqueuelen 1000  (Local Loopback)
        RX packets 21151  bytes 29270575 (29.2 MB)
        RX errors 0  dropped 0  overruns 0  frame 0
        TX packets 21151  bytes 29270575 (29.2 MB)
        TX errors 0  dropped 0 overruns 0  carrier 0  collisions 0
```

Ela não utiliza mecanismos de roteamento e nem a interface física de rede.

Unix Domain Socket são mais performáticos, mas dependem do SO para serem executados. Não é um protocolo universal como TCP/IP.
Caso necessite de perfomance dentro da mesma máquina, Unix Domain Socket é recomendado. 

Caso necessite de portabilidade e possibilidade dos processos rodarem em diferentes máquinas, TCP/IP é recomendado.


## referências
1. https://medium.com/codex/unix-domain-sockets-in-net-6-basics-and-real-world-examples-8982898ab293
1. https://lists.freebsd.org/pipermail/freebsd-performance/2005-February/001143.html
1. https://www.baeldung.com/cs/loopback-interface-routing-protocols




