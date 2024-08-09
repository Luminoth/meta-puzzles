package main

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestGetWrongAnswers(t *testing.T) {
	assert.Equal(t, "BAB", getWrongAnswers(3, "ABA"))
	assert.Equal(t, "AAAAA", getWrongAnswers(5, "BBBBB"))
}
