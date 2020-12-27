import socket
import threading

HOST=IP
PORT=PORT
CONN=(HOST, PORT)
FRM="utf-8"

count=0
s=socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind(CONN)

def thread_manager(conn,addr):
    if login(conn,addr):
        while True:
            msg=conn.recv(256).decode(FRM)
            if msg=="E":
                break
            else:
                conn.send(f"Error {msg} isn't an existing command".encode(FRM))
        print(f"{addr} disconnected")
    else:
        print("Authentication failed")

def login(conn,addr):
    try:
        conn.send("Inserire username: ".encode(FRM))
        user=conn.recv(64).decode(FRM)
        print(user, end=" ")
        conn.send("Inserire password: ".encode(FRM))
        pwd=conn.recv(64).decode(FRM)
        print(pwd)
        if pwd=="test":
            print("Access granted")
            conn.send("1".encode(FRM))
            return True
        else:
            print("Access refused")
            conn.send("0".encode(FRM))
            return False
    except Exception as e:
        print("Something went wrong\n\n",e)
        return False

def server():
    while True:
        print(f"Listening on {HOST}:{PORT}")
        s.listen()
        conn, addr=s.accept()
        print(f"{addr} connesso")
        thread=threading.Thread(target=thread_manager, args=(conn,addr))
        thread.start()

if __name__=="__main__":
    server()
