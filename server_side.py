import socket
import threading
IP="192.168.1.109"
PORT=8000
HOST=(IP, PORT)

server=socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind(HOST)

def handler(conn, addr):
    work=True
    print(f"{addr} connesso!")
    while work:
        msg=conn.recv(64).decode()
        if msg=="END":
            print(f"{}")
            conn.close()
            work=False
        else:
            print(f"RECEIVED {msg}", end="\t")

def main():
    server.listen()
    print(f"Listening on {IP}:{PORT}")
    while True:
        conn,addr=server.accept()
        thread=threading.Thread(target=handler, args=(conn,addr))
        thread.start()

if __name__=="__main__":
    main()