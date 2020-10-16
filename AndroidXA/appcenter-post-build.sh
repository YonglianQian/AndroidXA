echo "abcd"
echo $key1
echo $key2
echo $key1+$key2
echo $APPCENTER_OUTPUT_DIRECTORY
echo "............"
ls $APPCENTER_OUTPUT_DIRECTORY
echo ".........."
echo "................美丽的泡沫"
/Users/runner/Library/Android/sdk/build-tools/29.0.2/apksigner.bat verify --verbose --print-certs $APPCENTER_OUTPUT_DIRECTORY
echo "-----------------"