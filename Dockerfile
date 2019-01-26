FROM ubuntu:bionic

RUN apt update && DEBIAN_FRONTEND=noninteractive apt-get install -y tzdata && apt install -y mono-complete

# Replace 1000 with your user / group id
RUN export uid=1000 gid=1000 && \
    mkdir -p /home/dockeruser && \
    echo "dockeruser:x:${uid}:${gid}:dockeruser,,,:/home/dockeruser:/bin/bash" >> /etc/passwd && \
    echo "dockeruser:x:${uid}:" >> /etc/group && \
    mkdir -p /etc/sudoers.d/ && \
    echo "dockeruser ALL=(ALL) NOPASSWD: ALL" > /etc/sudoers.d/dockeruser && \
    chmod 0440 /etc/sudoers.d/dockeruser && \
    chown ${uid}:${gid} -R /home/dockeruser

USER dockeruser
ENV HOME /home/dockeruser
