#!/usr/bin/env bash
 
LOCA="$1"

subl "${LOCA}"
echo "LOCA=${LOCA}"
echo "Opening '$1' on line '$2' column '$3' with Sublime Text"
exit 0
