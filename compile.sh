pwd

docker run \
  --rm \
  -v `pwd`:`pwd` \
  -w `pwd` \
  -u $(id -u):$(id -g) \
  emscripten/emsdk \
  emcc fibonacci.c -o fibonacci.js